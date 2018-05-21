using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // troca especiífica
        private static void Trocar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        //trocar genérico
        private static void Trocar<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            bool b1 = true;
            bool b2 = false;

            Trocar<int>(ref a, ref b);
            Trocar<bool>(ref b1, ref b2);

            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);

            Console.WriteLine("b1: " + b1);
            Console.WriteLine("b2: " + b2);
            Console.ReadLine();
        }

        private static void TrocarTipos()
        {
            //trocando inteiros
            int a = 10;
            int b = 20;
            Trocar(ref a, ref b);
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);

            //trocando bool
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine("b1: " + b1);
            Console.WriteLine("b2: " + b2);
        }
    }
}
