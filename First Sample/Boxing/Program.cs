using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            object o = (object)a;

            Console.WriteLine(o.GetType().ToString());

            int b = (int)o;

            Console.WriteLine(b);

            System.Type t = b.GetType();
            
            Console.ReadKey();
        }
    }
}
