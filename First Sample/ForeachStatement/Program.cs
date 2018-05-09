using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ForeachStatement
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;
        }
        static void Main(string[] args)
        {
            Livro l1 = new Livro();
            l1.codigo = 1;
            l1.autor = "Machado de Assis";
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2 = new Livro();
            l2.codigo = 2;
            l2.autor = "Jorge Amado";
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 1965;

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);

            foreach (Livro item in livros)
            {
                Console.WriteLine("Código: " + item.codigo);
                Console.WriteLine("Título: " + item.titulo);
                Console.WriteLine("Autor: " + item.autor);
                Console.WriteLine("Ano Publicação: " + item.anoPublicacao);
                Console.WriteLine("--------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
