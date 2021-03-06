﻿using System;
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
    public class LogUserController : Controller
    {
        private ModeloDados db = new ModeloDados();

        // GET: LogUser
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "ID_USER,NOME,EMAIL,SENHA,TIPO")] Account logUser)
        {
            //tratar projeto login no futuro, estudar  . . 
            if (ModelState.IsValid)
            {
                var user = db.LogUsers.FirstOrDefault(x => x.EMAIL == logUser.EMAIL && x.SENHA == logUser.SENHA);

                if (user != null)
                {
                    //validando no controller para teste, vou validar na view futuramente

                    Session["Nome"] = user.NOME_USER;
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

        //get view teste :)
        public ActionResult View01()
        {
            return View();
        }

        
        // GET: LogUser/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account logUser = db.LogUsers.Find(id);
            if (logUser == null)
            {
                return HttpNotFound();
            }
            return View(logUser);
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
        public ActionResult Create([Bind(Include = "ID_USER,NOME,EMAIL,SENHA")] Account logUser)
        {
            if (ModelState.IsValid)
            {
                db.LogUsers.Add(logUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(logUser);
        }

        // GET: LogUser/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account logUser = db.LogUsers.Find(id);
            if (logUser == null)
            {
                return HttpNotFound();
            }
            return View(logUser);
        }

        // POST: LogUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_USER,NOME,EMAIL,SENHA")] Account logUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(logUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(logUser);
        }

        // GET: LogUser/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Account logUser = db.LogUsers.Find(id);
            if (logUser == null)
            {
                return HttpNotFound();
            }
            return View(logUser);
        }

        // POST: LogUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Account logUser = db.LogUsers.Find(id);
            db.LogUsers.Remove(logUser);
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
