using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class FormaPagamento
    {
        public abstract void Pagar(double valor);
    } 


    public class Boleto : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no boleto", valor);
        }
    }

    public class Cartao : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago valor de {0} no cartão", valor);
        }
    }

    public class Pedido
    {
        private FormaPagamento _forma;

        public void Pagar(double valor)
        {
            //delegação polimórfica
            this._forma.Pagar(valor);
        }

        public Pedido(FormaPagamento formaPagamento)
        {
            this._forma = formaPagamento;
        }
    }    
}
