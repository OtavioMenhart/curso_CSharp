using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PilhaFila
{
    public class Aluno
    {
        public int Matricula;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ExemploStack();
            ExemploQueue();
        }

        private static void ExemploQueue()
        {
            //FIFO - First In First Out
            var lista = new Queue<Aluno>();
            lista.Enqueue(new Aluno() { Matricula = 1, Nome = "Otávio" });
            lista.Enqueue(new Aluno() { Matricula = 2, Nome = "Menhart" });
            lista.Enqueue(new Aluno() { Matricula = 3, Nome = "Rocha" });
            //Console.WriteLine(lista.Peek().Nome);
            //Console.WriteLine("----------------------------------------");
            while (lista.Count > 0)
            {
                Console.WriteLine(lista.Dequeue().Nome);
            }
            Console.WriteLine("----------------------------------------");

            var qry = from aluno in lista
                      where aluno.Nome.Contains("a")
                      select aluno;

            foreach (Aluno aluno in qry)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.ReadKey();
        }

        private static void ExemploStack()
        {
            //LIFO - Last In First Out
            var pilha = new Stack<Aluno>();
            pilha.Push(new Aluno() { Matricula = 1, Nome = "Otávio" });
            pilha.Push(new Aluno() { Matricula = 2, Nome = "Menhart" });
            pilha.Push(new Aluno() { Matricula = 3, Nome = "Rocha" });

            foreach (Aluno a in pilha)
            {
                Console.WriteLine(a.Nome);
            }
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i <= pilha.Count; i++)
            {
                Console.WriteLine(pilha.Peek().Nome);
            }
            Console.WriteLine("----------------------------------------");

            while (pilha.Count > 0)
            {
                Console.WriteLine(pilha.Pop().Nome);
            }
            Console.ReadKey();
        }
    }
}
