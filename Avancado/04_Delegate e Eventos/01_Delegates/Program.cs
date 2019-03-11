using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);
        static void Main(string[] args)
        {
            // ponteiro, fazer referência
            // chamada mais simples

            /*JEITO NORMAL
            var so = Soma(10, 20);
            var su = Subtrair(20, 10);
            */

            Calcula calc1 = new Calcula(Soma);
            var so = calc1(10, 20);

            Calcula calc2 = new Calcula(Subtrair);
            var su = calc2(30, 15);

            Console.WriteLine("Soma: {0}\nSub: {1}", so, su);
            Console.ReadKey();
        }

        static int Soma(int a, int b)
        {
            return a + b;
        }

        static int Subtrair(int a, int b)
        {
            return a - b;
        }

    }
}
