using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };
            var maiores = lista.Where(x => x > 10).OrderBy(x => x).Select(x => x);

            foreach (var item in maiores)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
