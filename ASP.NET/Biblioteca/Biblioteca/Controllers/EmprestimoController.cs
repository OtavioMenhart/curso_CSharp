using Biblioteca.DataContext;
using Biblioteca.Helpers;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class EmprestimoController : Controller
    {
        private BibliotecaDB db = new BibliotecaDB();
        // GET: Emprestimo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Emprestimo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Emprestimo/Create
        public ActionResult Create()
        {
            @ViewBag.Clientes = RetornaSelectListItem.Clientes();
            @ViewBag.Livros = RetornaSelectListItem.LivrosNaoEmprestados();
            return View();
        }

        // POST: Emprestimo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Emprestimo emprestimo)
        {
            if (ModelState.IsValid)
            {
                db.Emprestimos.Add(emprestimo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            @ViewBag.Clientes = RetornaSelectListItem.Clientes();
            @ViewBag.Livros = RetornaSelectListItem.LivrosNaoEmprestados();
            return View(emprestimo);
        }

        // GET: Emprestimo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Emprestimo/Edit/5
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

        // GET: Emprestimo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Emprestimo/Delete/5
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
