using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _03_TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());

            

            string[] enderecos = new string[] { "https://www.google.com/", "https://www.microsoft.com/pt-br", "https://www.globo.com/" };

            var listaEnd = from end in enderecos select DownloadPagina(end);

            Task.WaitAll(listaEnd.ToArray());

            Console.WriteLine("Finalizado!!");
            Console.ReadKey();
        }

        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Valor: {0} - Task ID: {1}", i, Task.CurrentId);
            }
        }

        static async Task DownloadPagina(string end)
        {
            WebClient web = new WebClient();
            string html = await web.DownloadStringTaskAsync(end);
            Console.WriteLine("Download página: {0}", end);
        }
    }
}
