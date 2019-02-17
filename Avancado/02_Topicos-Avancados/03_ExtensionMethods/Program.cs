using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor = "olá mundo!";

            string primeiraMaiuscula = StringExtension.FirstToUpper(valor);

            Console.WriteLine("Primeiro valor: {0}\nSegundo valor: {1}", valor, primeiraMaiuscula);
            Console.ReadKey();
        }
    }
}
