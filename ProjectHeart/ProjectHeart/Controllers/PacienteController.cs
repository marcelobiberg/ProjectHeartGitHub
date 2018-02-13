using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;

using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectHeart.Models;

namespace ProjectHeart.Controllers
{
    public class PacienteController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }

        //get teste fins didáticos
        public ActionResult teste()
        {
            return View();
        }

        // GET: Paciente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Pacientes.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            

            //ViewData["convenio"] = listConv;

            return View();
        }

        // POST: Paciente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_CONVENIO,NOME,NR_CONVENIO,NOME_CONVENIO,RG,RESPONSAVEL,ESTADO,ENDERECO,NR_CARTEIRA,CIDADE,CPF,CEP,SEXO,COMPLEMENTAR,UF,BAIRRO,CELULAR,TELEFONE,TELEFONE2,EMAIL,NATURALIDADE,DATA_NASC,PROFISSAO")] Paciente paciente,string nroCasa, string ckSMS,string ckStatus,string convenio, string etnia, string EstCiv, string encaminhador)
        {

            if (ModelState.IsValid)
            {
                //tratamento para sms e status paciente, de forma paliativa, pois gera bug no binder com htmlhelper checkboxFor
                if (ckSMS == "")
                {
                    paciente.SMS = "V";
                }
                else
                {
                    paciente.SMS = "F";
                }

                if (ckStatus == "")
                {
                    paciente.STATUS = "V";
                }
                else
                {
                   
                    paciente.STATUS = "F";
                }

                //tratamento do endereço, recebe nroCasa da view, NroCasa n tem na model por isso o concat
                paciente.ENDERECO = paciente.ENDERECO + ", " + nroCasa;

                //logic for ID_CONVENIO
                //var p1 = db.Convenios.Where(m =>m.NOME_CONVENIO == convenio);

                //foreach (var item in p1)
                //{
                //    if (item.NOME_CONVENIO == convenio)
                //    {
                        paciente.ID_CONVENIO = 3;
                        //paciente.NOME_CONVENIO = "Particular";
                //    }
                //} 

                //Paciente p1 = new Paciente();

                //p1.ID_CONVENIO = 3;
                //p1.NOME = paciente.NOME;
                //p1.RG = paciente.RG;
                //p1.RESPONSAVEL = "";
                //p1.UF = paciente.UF;
                //p1.ENDERECO = paciente.ENDERECO;
                //p1.NR_CONVENIO = paciente.NR_CONVENIO;
                //p1.NOME_CONVENIO = paciente.NOME_CONVENIO;
                //p1.CIDADE = paciente.CIDADE;
                //p1.CPF = paciente.CPF;
                //p1.STATUS = paciente.STATUS;
                //p1.CEP = paciente.CEP;
                //p1.BAIRRO = paciente.BAIRRO;
                //p1.EMAIL = paciente.EMAIL;
                //p1.COMPLEMENTAR = paciente.COMPLEMENTAR;
                //p1.PROFISSAO = paciente.PROFISSAO;
                //p1.SEXO = paciente.SEXO;
                //p1.CELULAR = paciente.CELULAR;
                //p1.TELEFONE = paciente.TELEFONE;
                //p1.TELEFONE2 = paciente.TELEFONE2;
                //p1.NATURALIDADE = paciente.NATURALIDADE;
                //p1.SMS = paciente.SMS;
                //p1.DATA_NASC = paciente.DATA_NASC;

                db.Pacientes.Add(paciente);
                db.SaveChanges();
                

                return RedirectToAction("Index", "Home");
            }

            //ViewBag.ID_CONVENIO = new SelectList(db.Convenios, "ID_CONVENIO", "NR_CONVENIO", paciente.ID_CONVENIO);
            return View(paciente);
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Pacientes.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            //ViewBag.ID_CONVENIO = new SelectList(db.Convenios, "ID_CONVENIO", "NR_CONVENIO", paciente.ID_CONVENIO);
            return View(paciente);
        }

        // POST: Paciente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PACIENTE,ID_CONVENIO,NOME_PACIENTE,RG,RESPONSAVEL,ESTADO,ENDERECO,NR_CARTEIRA,CIDADE,CPF")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paciente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.ID_CONVENIO = new SelectList(db.Convenios, "ID_CONVENIO", "NR_CONVENIO", paciente.ID_CONVENIO);
            return View(paciente);
        }

        // GET: Paciente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Paciente paciente = db.Pacientes.Find(id);
            if (paciente == null)
            {
                return HttpNotFound();
            }
            return View(paciente);
        }

        // POST: Paciente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Paciente paciente = db.Pacientes.Find(id);
            db.Pacientes.Remove(paciente);
            db.SaveChanges();
            return RedirectToAction("Index");
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
