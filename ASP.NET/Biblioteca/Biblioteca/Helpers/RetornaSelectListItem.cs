using Biblioteca.DataContext;
using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Helpers
{
    public class RetornaSelectListItem
    {
        private static BibliotecaDB db = new BibliotecaDB();
        public static List<SelectListItem> Autores()
        {
            List<Autor> lAutores = new List<Autor>();
            lAutores = db.Autores.ToList();
            List<SelectListItem> listaAutores = lAutores.ConvertAll(a => {
                return new SelectListItem()
                {
                    Text = a.Nome,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });
            return listaAutores;
        }

        public static List<SelectListItem> Categorias()
        {
            List<Categoria> lCategoria = new List<Categoria>();
            lCategoria = db.Categorias.ToList();
            List<SelectListItem> listaCategorias = lCategoria.ConvertAll(a => {
                return new SelectListItem()
                {
                    Text = a.Nome,
                    Value = a.Id.ToString(),
                    Selected = false
                };
            });
            return listaCategorias;
        }
    }
}