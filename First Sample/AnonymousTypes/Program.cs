using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new[] { new { idade = 18, nome = "Luis" }, new { idade = 20, nome = "Otavio" } };

            foreach (var item in valores)
            {
                Console.WriteLine("Idade: " + item.idade.ToString() + " Nome: " + item.nome);
            }
            Console.ReadKey();
        }
    }
}
