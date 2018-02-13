using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ProjectHeart.Models;

namespace ProjectHeart.Controllers
{
    public class AccountController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: LogUser
        public ActionResult Index(int? id)
        {
            //valida dropdown
            //private SelectList GetCarsSelectList()
            //{
            //    return new SelectList(Car.GetCars(), "Id", "Name", "Category", 1);
            //}

            //logic to create user success
            if (Session["VU"] != null)
            {
                ViewBag.valida = "cadastrado";
                ModelState.AddModelError(string.Empty, "Usuário editado com sucesso!");
                Session["VU"] = "";
                return View();
            }

            if (id != null)
            {
                List<Account> logUser;

                var query = from q1 in db.Accounts
                            where q1.ID_USER == id 
                            select q1;
                logUser = query.AsNoTracking().ToList();

                return View(logUser);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID_USER,EMAIL,SENHA,TIPO")] Account logUser, string search,string ckSearch)
        {
            //valida: s=success; d=danger 

            //logic para lista de account do DB
            List<Account> result = null;

            //valida input search
            if (search == "")
            {
                ViewBag.valida = "d"; 
                ModelState.AddModelError(string.Empty, "Preencha o campo!");
                return View();  
            }
           
            //valida dropdown email ou senha
            if (ckSearch == "e")
            {
                var query = from q1 in db.Accounts
                            where q1.EMAIL.Contains(search)//contais ==  o operador like do sql
                            select q1;
                result = query.AsNoTracking().ToList();
            }
            else
            {
                int id;
                Int32.TryParse(search, out id);

                var query = from q1 in db.Accounts
                            where q1.ID_USER == id
                            select q1;
                result = query.AsNoTracking().ToList();
            }

            if (result != null && result.Count != 0)
            {
                ModelState.Clear();
                return View(result);
            }
            else
            {
                ModelState.Clear();
                ViewBag.valida = "d";
                ModelState.AddModelError(string.Empty, "Usuário não encontrado!");
                ViewBag.trigger = "trigger";
            }
            return View();
        }

        // GET: LogUser/Details/5
        public ActionResult Login()
        {
            return View();
        }

        // GET: ViewTest
        public ActionResult ViewTest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([Bind(Include = "ID_USER,EMAIL,SENHA,TIPO")] Account logUser)
        {
            //tratar projeto login no futuro, estudar  . . 
            if (ModelState.IsValid)
            {
                var user = db.Accounts.FirstOrDefault(x => x.EMAIL == logUser.EMAIL && x.SENHA == logUser.SENHA);

                if (user != null)
                {
                    //validando no controller para teste, vou validar na view futuramente

                    //criar logic para nome do user
                    Session["Tipo"] = user.TIPO;
                    Session["Email"] = user.EMAIL;
                    return RedirectToAction("../Home/DashBoardHome");
                }
                else
                {
                    ModelState.Clear();
                    ModelState.AddModelError(string.Empty, "Usuário não encontrado!");
                    //ViewData["UserNotFOund"] = "Usuário não encontrado!";
                    return View();
                }
            }
            return View();
        }

        // GET: LogUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_USER,TIPO,EMAIL,SENHA")] Account logUser, string confSenha)
        {
            if (ModelState.IsValid)
            {
                //logic for validation 
                bool userEmail = db.Accounts.Any(p => p.EMAIL == logUser.EMAIL);
                if (userEmail == true)
                {
                    ModelState.AddModelError(string.Empty, "E-mail já cadastrado!");
                    return View(logUser);
                }

                if (logUser.TIPO == "Selecione tipo" || logUser.SENHA != confSenha)
                {
                    if (logUser.TIPO == "Selecione tipo")
                    {
                        ModelState.AddModelError(string.Empty, "Informe tipo do profissional!");
                    }

                    if (logUser.SENHA != confSenha)
                    {
                        ModelState.AddModelError(string.Empty, "Senha não confere!");
                    }

                    return View(logUser);
                }
                else
                {
                    logUser.DATA_LOG = DateTime.Now;
                    db.Accounts.Add(logUser);
                    db.SaveChanges();
                    ModelState.Clear();

                    ModelState.AddModelError(string.Empty, "Usuário: "+logUser.EMAIL+", cadastrado com sucesso!");
                    ViewBag.valida = "cadastrado";
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty,"Preencha os campos obrigatórios!");
                return View(logUser);
            }
        }

        // GET: account reset de senha via email/Edit/5
        public ActionResult Forgot_Password()
        {
            return View();
        }

        // POST: LogUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Forgot_Password([Bind(Include = "EMAIL")] ForgotPassword MailForgot, ProjectHeart.Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                var resultado = db.Accounts.AsNoTracking().Where(p => p.EMAIL == MailForgot.EMAIL).Select(p => new { SENHA = p.SENHA, EMAIL = p.EMAIL});

                //popular o corpo do e-mail
                _objModelMail.To = MailForgot.EMAIL;
                _objModelMail.From = "medilabplusemailautomatic@gmail.com";
                _objModelMail.Subject = "Reset senha - Medilab Plus";
                //LOGIC para enviar senho no corpo o email, se email exist no DB
                foreach (var item in resultado)
                {
                    if (item.EMAIL == MailForgot.EMAIL)
                    {
                        var AmOuPm = DateTime.Now.TimeOfDay;
                        if (AmOuPm.Hours <= 12)
                        {
                            _objModelMail.Body = "Boa " + "dia,";
                        }
                        else
                        {
                            _objModelMail.Body = "Boa " + "tarde,";
                        }
                    }
                    _objModelMail.Body += "<br /><br />   Usuário: " + item.EMAIL;
                    _objModelMail.Body += "<br /><br />   Senha: " + item.SENHA;
                }

                //Instância classe email
                MailMessage mail = new MailMessage();
                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                //Instância smtp do servidor, neste caso o gmail.
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new System.Net.NetworkCredential
                ("medilabplusemailautomatic@gmail.com", "mar142536");// Login e senha do e-mail.
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index");
            }
            else
            {
                return View();
            }
        }
    

        // GET: LogUser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account logUser = db.Accounts.Find(id);
            if (logUser == null)
            {
                return HttpNotFound();
            }
            return View(logUser);
        }

        // Get: LogUser/Delete/5
        public ActionResult Edit(int? id)
        {
            //trocar param find para ID, dont forgot ==============*
            Account logUser = db.Accounts.Find(1);
            if (logUser != null)
            {
                TempData["valida"] = logUser.EMAIL;
                return View(logUser);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_USER,TIPO,EMAIL,SENHA")] Account logUser)
        {
            if (ModelState.IsValid)
            {
                //VE = valida email
                if (logUser.EMAIL == TempData["valida"].ToString())
                {
                    Session["VU"] = "cadastrado";
                    logUser.DATA_LOG = DateTime.Now;
                    db.Entry(logUser).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                else
                {
                    bool VE = db.Accounts.Any(x => x.EMAIL == logUser.EMAIL);
                    if (VE != false)
                    {
                        //logic for validation, stand by
                        return View(logUser);
                    }
                    else
                    {
                        ViewBag.validaUser = "Usuário editado com sucesso!";
                        logUser.DATA_LOG = DateTime.Now;
                        db.Entry(logUser).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }
                }
            }
            return View(logUser);
        }

        // POST: LogUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account logUser = db.Accounts.Find(id);
            db.Accounts.Remove(logUser);
            db.SaveChanges();
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
