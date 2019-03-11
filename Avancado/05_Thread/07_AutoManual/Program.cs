using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_AutoManual
{
    class Program
    {
        static ManualResetEvent manual01;
        static AutoResetEvent auto01;

        static void Main(string[] args)
        {
            manual01 = new ManualResetEvent(false);
            auto01 = new AutoResetEvent(false);


            //Thread t1 = new Thread(Executa01);
            //t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            manual01.Set();
            manual01.Reset();
            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set();
            auto01.Set();

            Console.ReadKey();
        }

        static void Executa01()
        {
            Console.WriteLine("01 - iniciado Executa01");
            manual01.WaitOne();
            Console.WriteLine("02 - em execucao Executa01");
            Console.WriteLine("03 - em execucao2 Executa01");
            manual01.WaitOne();
            Console.WriteLine("04 - finalizado Executa01");
        }

        static void Executa02()
        {
            Console.WriteLine("01 - iniciado Executa02");
            auto01.WaitOne();
            Console.WriteLine("02 - em execucao Executa02");
            auto01.WaitOne();
            Console.WriteLine("03 - em execucao2 Executa02");
            Console.WriteLine("04 - finalizado Executa02");
        }
    }
}
