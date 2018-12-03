using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EngReversa.Models;

namespace EngReversa.Controllers
{
    public class ClienteController : Controller
    {
        private BD_OS_SERVICOContext db = new BD_OS_SERVICOContext();

        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.TB_CLIENTE.ToList());
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_CLIENTE tB_CLIENTE = db.TB_CLIENTE.Find(id);
            if (tB_CLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(tB_CLIENTE);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TB_CLIENTE_CODIGO,TB_CLIENTE_NOME,TB_CLIENTE_ENDERECO,TB_CLIENTE_PONTO_REFERENCIA,TB_CLIENTE_NUMERO,TB_CLIENTE_CEP,TB_CLIENTE_CPF,TB_CLIENTE_RG,TB_CLIENTE_BAIRRO,TB_CLIENTE_CIDADE,TB_CLIENTE_TELEFONE,TB_CLIENTE_EMAIL,TB_CLIENTE_DATA_CADASTRO,TB_CLIENTE_DATA_NASCIMENTO")] TB_CLIENTE tB_CLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.TB_CLIENTE.Add(tB_CLIENTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tB_CLIENTE);
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_CLIENTE tB_CLIENTE = db.TB_CLIENTE.Find(id);
            if (tB_CLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(tB_CLIENTE);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TB_CLIENTE_CODIGO,TB_CLIENTE_NOME,TB_CLIENTE_ENDERECO,TB_CLIENTE_PONTO_REFERENCIA,TB_CLIENTE_NUMERO,TB_CLIENTE_CEP,TB_CLIENTE_CPF,TB_CLIENTE_RG,TB_CLIENTE_BAIRRO,TB_CLIENTE_CIDADE,TB_CLIENTE_TELEFONE,TB_CLIENTE_EMAIL,TB_CLIENTE_DATA_CADASTRO,TB_CLIENTE_DATA_NASCIMENTO")] TB_CLIENTE tB_CLIENTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tB_CLIENTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tB_CLIENTE);
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TB_CLIENTE tB_CLIENTE = db.TB_CLIENTE.Find(id);
            if (tB_CLIENTE == null)
            {
                return HttpNotFound();
            }
            return View(tB_CLIENTE);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TB_CLIENTE tB_CLIENTE = db.TB_CLIENTE.Find(id);
            db.TB_CLIENTE.Remove(tB_CLIENTE);
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
