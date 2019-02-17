using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();
            listaAutor.Add(new Autor() { Id = 1, Nome = "Leonardo" });
            listaAutor.Add(new Autor() { Id = 2, Nome = "Maria" });
            listaAutor.Add(new Autor() { Id = 3, Nome = "Joseph" });

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(new Livro() { Id = 1, AutorId = 2, Titulo = "Amor Amado", AnoPublicacao = "2015" });
            listaLivro.Add(new Livro() { Id = 2, AutorId = 2, Titulo = "Bem Amado", AnoPublicacao = "2015" });
            listaLivro.Add(new Livro() { Id = 3, AutorId = 3, Titulo = "Um Espião em Washington", AnoPublicacao = "2015" });
            listaLivro.Add(new Livro() { Id = 4, AutorId = 1, Titulo = "Vida na Terra", AnoPublicacao = "2015" });

            var listaJoin =
                            from livros in listaLivro
                            join autores in listaAutor on livros.AutorId equals autores.Id
                            select new
                            {
                                livros.Titulo,
                                autores.Nome
                            };


            foreach (var item in listaJoin)
            {
                Console.WriteLine("Livro: {0} - Autor: {1}", item.Titulo, item.Nome);
            }
            Console.ReadKey();
        }
    }
}
