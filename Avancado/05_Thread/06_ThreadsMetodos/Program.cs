using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_ThreadsMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início");
            Thread.Sleep(3000);
            Console.WriteLine("Término");

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join();

            Console.WriteLine("Término");
            Console.WriteLine("Término");
            Console.WriteLine("Término");

            Console.ReadKey();
        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Thread: {0} - Num: {1} - ID interno: {2}", id, i, Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
