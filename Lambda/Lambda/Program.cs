using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 2500;
            var pedido = new Pedido();
            //pedido.PagarEvent += new PagarNotify(PagarBoleto);
            pedido.PagarEvent += v => Console.WriteLine("Pago no cartão valor de: " + v);
            pedido.Pagar(valor);
            Console.ReadLine();
        }

        public static void PagarBoleto(double valor)
        {
            Console.WriteLine("Pago no boleto valor de: " + valor);
        }
    }
}
