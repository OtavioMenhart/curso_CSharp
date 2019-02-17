using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario() { Nome = "José", Email = "jose@gmail.com" });
            lista.Add(new Usuario() { Nome = "Maria", Email = "maria@gmail.com" });
            lista.Add(new Usuario() { Nome = "Felipe", Email = "felipe@gmail.com" });
            lista.Add(new Usuario() { Nome = "João", Email = "joao@hotmail.com" });
            lista.Add(new Usuario() { Nome = "Elias", Email = "elias@hotmail.com" });

            var listaFiltrada = lista.Where(x => x.Email.Contains("gmail"));

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine("{0} - {1}", item.Nome, item.Email);
            }
            Console.ReadKey();
        }
    }
}
