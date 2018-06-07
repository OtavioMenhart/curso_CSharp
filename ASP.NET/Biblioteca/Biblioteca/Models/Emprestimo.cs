using Biblioteca.DataContext;
using Biblioteca.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public virtual int Id { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Cliente Cliente { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data empréstimo")]
        public virtual DateTime DataEmprestimo { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayName("Data da devolução")]
        public virtual DateTime DataDevolucao { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Data de entrega do livro")]
        public virtual DateTime DataDeEntregaDoLivro { get; set; }

        [Required]
        public virtual int LivroID { get; set; }

        [Required]
        public virtual int ClienteId { get; set; }

        [DisplayName("Valor Pago")]
        public virtual decimal ValorPago { get; set; }

        [DisplayName("Livro devolvido")]
        [DefaultValue(false)]
        public virtual bool LivroFoiDevolvido { get; set; }

        public void CadastrarEmprestimo (Emprestimo emprestimo)
        {
            Livro.AtualizaQuantidadeLivroEmprestado(emprestimo.LivroID);
            using(BibliotecaDB db = new BibliotecaDB())
            {
                db.Emprestimos.Add(emprestimo);
                db.SaveChanges();
            }
        }

        public void CadastrarDevolucao(Emprestimo emprestimo)
        {
            emprestimo.ValorPago = Calcula.ValorEmprestimoLivro(emprestimo);
            Livro.AtualizaQuantidadeLivroDevolucao(emprestimo.LivroID);
            emprestimo.LivroFoiDevolvido = true;
            using(BibliotecaDB db = new BibliotecaDB())
            {
                db.Entry(emprestimo).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}