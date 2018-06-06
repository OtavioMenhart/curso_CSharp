using Biblioteca.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public virtual int Id { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual DateTime DataEmprestimo { get; set; }
        public virtual DateTime DataDevolucao { get; set; }

        [Required]
        public virtual int LivroID { get; set; }

        [Required]
        public virtual int ClienteId { get; set; }

        public void CadastrarEmprestimo (Emprestimo emprestimo)
        {
            Livro.AtualizaQuantidadeLivroEmprestado(emprestimo.LivroID);
            using(BibliotecaDB db = new BibliotecaDB())
            {
                db.Emprestimos.Add(emprestimo);
                db.SaveChanges();
            }
        }
    }
}