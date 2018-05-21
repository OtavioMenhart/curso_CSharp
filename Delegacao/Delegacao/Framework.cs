using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    public class Pedido
    {
        //associação
        private FormaPagamento _forma;
        public void Fechar(double valor)
        {
            //delegação polimórfica
            this._forma.Pagar(valor);
        }

        public Pedido (FormaPagamento forma)
        {
            //guardo internamente a forma de pagamento que foi passada no construtor
            //para q depois seja feita a delegação
            this._forma = forma;
        }
    }

    public abstract class FormaPagamento
    {
        public abstract void Pagar(double valor);
    }

    public class Boleto : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago boleto no valor de: " + valor);
        }
    }

    public class Cartao : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago cartao no valor de: " + valor);
        }
    }

    public class Cheque : FormaPagamento
    {
        public override void Pagar(double valor)
        {
            Console.WriteLine("Pago cheque no valor de: " + valor);
        }
    }            
}
