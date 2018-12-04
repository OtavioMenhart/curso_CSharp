using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserir();
            //Listar();
            //Excluir();
            //ExcluirEntity();
            //Editar();
            //InserirEstudanteEndereco();
            //ListarComEndereco();
            //ListagemRelacionada();
            //InserirCursosEstudantes();
            //InserirDetalheEstudantes();

            using (var db = new ApplicationDbContext())
            {
                var estudante = db.Estudantes.Include(x => x.EstudanteDetalhe).ToList();
                
            }
        }

        private static void InserirDetalheEstudantes()
        {
            using (var db = new ApplicationDbContext())
            {
                var estudante = new Estudante();
                estudante.Nome = "Rocha";
                estudante.Idade = 21;
                estudante.EstaExcluido = false;
                estudante.TurmaId = 1;

                var det = new EstudanteDetalhe();
                det.Debito = false;
                det.Area = "Programação";
                det.CategoriaPagamento = 1;

                estudante.EstudanteDetalhe = det;

                db.Add(estudante);
                db.SaveChanges();
            }
        }

        private static void InserirCursosEstudantes()
        {
            using (var db = new ApplicationDbContext())
            {
                var estudante = db.Estudantes.FirstOrDefault();
                var curso = db.Curso.FirstOrDefault();

                var ec = new EstudanteCurso();
                ec.CursoId = 2;
                ec.EstudanteId = 5;
                ec.Ativo = false;

                db.Add(ec);
                db.SaveChanges();
            }
        }

        private static void ListagemRelacionada()
        {
            using (var context = new ApplicationDbContext())
            {
                var estudantes = context.Turmas.Where(x => x.Id == 1).Include(x => x.Estudantes).ToList();
            }
        }

        private static void ListarComEndereco()
        {
            using (var context = new ApplicationDbContext())
            {
                var estudantes = context.Estudantes.Include(x => x.Endereco).ToList();
            }
        }


        private static void InserirEstudanteEnderecoRelacional()
        {
            using (var db = new ApplicationDbContext())
            {
                var estudanteOtavio = new Estudante();
                estudanteOtavio.Id = 2;

                var endereco = new Endereco();
                endereco.Rua = "Rua 5";
                endereco.EstudanteId = estudanteOtavio.Id;

                db.Enderecos.Add(endereco);
                db.SaveChanges();

            }

        }

        private static void InserirEstudanteEndereco()
        {
            using (var db = new ApplicationDbContext())
            {
                var estudante = new Estudante();
                estudante.Nome = "Otávio Rocha";
                estudante.Idade = 20;

                var endereco = new Endereco();
                endereco.Rua = "Rua A";
                estudante.Endereco = endereco;

                db.Estudantes.Add(estudante);
                db.SaveChanges();

            }

        }

        private static void Editar()
        {
            Estudante est;
            using (var context = new ApplicationDbContext())
            {
                est = context.Estudantes.Where(x => x.Id == 1).FirstOrDefault();
                est.Nome = "Otávio Menhart";
                context.Estudantes.Update(est);
                context.SaveChanges();
            }
        }

        private static void ExcluirEntity()
        {
            Estudante est;

            using (var context = new ApplicationDbContext())
            {
                est = context.Estudantes.Where(x => x.Id == 1).FirstOrDefault();
                context.Entry(est).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private static void Excluir()
        {
            Estudante est;
            using (var context = new ApplicationDbContext())
            {
                est = context.Estudantes.Where(x => x.Id == 1).FirstOrDefault();
                context.Estudantes.Remove(est);
                context.SaveChanges();
            }
        }

        private static void Listar()
        {
            using (var context = new ApplicationDbContext())
            {
                var estudantes = context.Estudantes.Where(x => x.Nome == "Otávio").ToList();
            }
        }

        private static void Inserir()
        {
            using (var context = new ApplicationDbContext())
            {
                var estudante = new Estudante();
                estudante.Nome = "Hugo";
                context.Estudantes.Add(estudante);
                context.SaveChanges();
            }
        }
    }

    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Endereco Endereco { get; set; }
        public bool EstaExcluido { get; set; }
        public int TurmaId { get; set; }

        public List<EstudanteCurso> EstudantesCursos { get; set; }
        public EstudanteDetalhe EstudanteDetalhe { get; set; }
    }

    public class EstudanteDetalhe
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public bool Debito { get; set; }
        public int CategoriaPagamento { get; set; }
        public Estudante Estudante { get; set; }
    }

    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int EstudanteId { get; set; }
    }

    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Estudante> Estudantes { get; set; }
    }

    public class Curso
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public List<EstudanteCurso> EstudantesCursos { get; set; }
    }

    public class EstudanteCurso
    {
        public int EstudanteId { get; set; }
        public int CursoId { get; set; }
        public bool Ativo { get; set; }
        public Estudante Estudante { get; set; }
        public Curso Curso { get; set; }
    }
}
