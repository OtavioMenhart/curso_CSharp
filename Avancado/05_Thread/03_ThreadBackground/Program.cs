using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_ThreadBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data ini: {0}", DateTime.Now);

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.IsBackground = true; //executa enquanto o fluxo principal estiver sendo executado
                t1.Start();
            }
            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Num: {0}", i);
            }
            Console.WriteLine("Datetime: {0}", DateTime.Now);
        }
    }
}
