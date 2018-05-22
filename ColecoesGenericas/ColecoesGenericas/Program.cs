using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ColecoesGenericas
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
        public string Curso;

        public override string ToString()
        {
            return Matricula.ToString() + " - " + Nome + " - " + Curso;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            alunos.Add(new Aluno() { Matricula = 1, Nome = "Otávio", Curso = "SI" });
            alunos.Add(new Aluno() { Matricula = 2, Nome = "Menhart", Curso = "CC" });
            alunos.Add(new Aluno() { Matricula = 3, Nome = "Ballonje", Curso = "SI" });
            alunos.Add(new Aluno() { Matricula = 4, Nome = "Rocha", Curso = "CC" });
            foreach (Aluno item in alunos)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Iforme o curso (CC ou SI)");
            string curso = Console.ReadLine();
            var qry = from aluno in alunos
                      where aluno.Curso == curso
                      select aluno;
            foreach (Aluno aluno in qry)
            {
                Console.WriteLine(aluno);
            }
            Console.ReadKey();
        }

        private static void ExemploArrayList()
        {
            var alunos = new ArrayList();
            alunos.Add(1);
            alunos.Add("Otávio");
            alunos.Add(new SqlConnection()); //aceita qualquer coisa
            foreach (var item in alunos)
            {
                Console.WriteLine(item);
            }
            var obj = alunos[2]; // retira *sempre* um object
            if (obj is SqlConnection)
            {
                (obj as SqlConnection).Open();
            }
        }
    }
}
