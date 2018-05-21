using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // UI
    class Program
    {
        //associação concreta
        //private static EMail email = new EMail();
        //private static SMS sms = new SMS();

        //associação para abstração
        private static INotificacao notificacao;

        static void Main(string[] args)
        {
            string Mensagem = "Ola Mundo";
            notificacao = new Funcionario();
            notificacao.Enviar(Mensagem); //delegação
            Console.ReadLine();
        }
    }
}
