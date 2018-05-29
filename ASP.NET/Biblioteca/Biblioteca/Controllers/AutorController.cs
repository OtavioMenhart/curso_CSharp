using Biblioteca.DataContext;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class AutorController : Controller
    {
        private BibliotecaDB db = new BibliotecaDB();
        // GET: Autor
        public ActionResult Index()
        {
            return View();
        }

        // GET: Autor/Details/5
        public ActionResult Details()
        {
            List<Autor> autores = db.Autores.ToList();
            return View(autores);
        }

        // GET: Autor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Autores.Add(autor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autor);
        }

        // GET: Autor/Edit/5
        public ActionResult Edit(int id)
        {
            Autor autor = db.Autores.Find(id);
            if (autor.Id == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        // POST: Autor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(autor);
        }

        // GET: Autor/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: Autor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Autor autor = db.Autores.Find(id);
            db.Autores.Attach(autor);
            db.Autores.Remove(autor);
            db.SaveChanges();
            return Content("Autor removido com sucesso");
        }
    }
}
