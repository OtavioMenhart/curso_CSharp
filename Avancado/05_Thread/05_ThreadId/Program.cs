using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                t1.Start(i);
            }
            Console.WriteLine("Programa finalizado");
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
