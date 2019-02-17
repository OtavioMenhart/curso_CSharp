using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;
            t2 = "";

            var v1 = "";
            var v2 = 123456;
            //ERRO: var v3;
            //ERRO: v2 = "";

            dynamic d1 = new Usuario() { Nome = "Maria"};
            Console.WriteLine(d1.Nome);
            Console.WriteLine(d1.Senha); //vai dar erro somente quando executar
            

        }

        class Usuario
        {
            public string Nome { get; set; }
        }
    }
}
