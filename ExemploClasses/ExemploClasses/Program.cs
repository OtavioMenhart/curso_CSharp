using System;
using Menhart.Util;

namespace ExemploClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            string xStr = Console.ReadLine(); //UI
            string yStr = Console.ReadLine(); //UI

            int x = Convert.ToInt32(xStr);
            int y = Convert.ToInt32(yStr);

            Calculadora calc = new Calculadora();

            int r = calc.Somar(x, y);
            Console.WriteLine(r.ToString()); //UI
            Console.ReadKey();
        }

    }
}
