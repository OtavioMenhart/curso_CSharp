using Biblioteca.DataContext;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
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
        public ActionResult Details(int id)
        {
            return View();
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
            return View();
        }

        // POST: Autor/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Autor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Autor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
