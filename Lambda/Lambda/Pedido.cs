using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
   public delegate void PagarNotify(double valor);
   public class Pedido
   {
        //ponteiro para um método
        //forma de injetar código no framework
        //código da implementação vem de fora
        public event PagarNotify PagarEvent;

        public void Pagar(double valor)
        {
            //delegação
            this.PagarEvent(valor);
        }
   }

    
}
