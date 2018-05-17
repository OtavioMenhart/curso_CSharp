using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new Cartao()); //injeto a dependência
            double valor = 2000;
            pedido.Pagar(valor);
            Console.ReadLine();
        }
    }
}
