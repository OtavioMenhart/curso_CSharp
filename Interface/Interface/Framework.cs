using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface INotificacao
    {
        void Enviar(string Mensagem);
    }

    public abstract class Notificacao : INotificacao
    {
        public abstract void Enviar(string Mensagem);
    }

    public class EMail : Notificacao
    {
        public override void Enviar (string Mensagem)
        {
            Console.WriteLine("Enviando email: " + Mensagem);
        }
    }

    public class SMS : Notificacao
    {
        public override void Enviar (string Mensagem)
        {
            Console.WriteLine("Enviando SMS: " + Mensagem);
        }
    }

    public class Pessoa
    {
        public string Nome;
    }

    public class Funcionario : Pessoa, INotificacao
    {
        public void Enviar(string Mensagem)
        {
            Console.WriteLine("Pessoa está notificando: " + Mensagem);
        }
    }
}
