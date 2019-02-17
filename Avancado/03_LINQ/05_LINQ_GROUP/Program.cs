using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            //group ou distinct

            var listaDistinct = listaNum.OrderBy(x => x).Distinct();
            Console.WriteLine("Lista com distinct:");
            foreach (var item in listaDistinct)
            {
                Console.WriteLine(item);
            }

            var listaGroup = listaNum.OrderBy(x => x).GroupBy(x => x);
            Console.WriteLine("\nLista com group:");
            foreach (var item in listaGroup)
            {
                Console.WriteLine(item.Key);
            }

            Console.ReadKey();
        }
    }
}
