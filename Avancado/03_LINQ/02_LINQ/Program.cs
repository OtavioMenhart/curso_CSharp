using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var maiores = from l in lista where l > 10 select l;

            foreach (var item in maiores)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
