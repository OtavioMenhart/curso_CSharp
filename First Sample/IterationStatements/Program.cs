using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            //inicio do while
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 10);
            //fim do while

            //inicio while
            while (a < 10)
            {
                Console.WriteLine(a);
                a++;
            }
            //fim while

            Console.ReadKey();
        }
    }
}
