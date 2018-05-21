using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract
{
    public enum TipoEnvio { EMAIL = 0, SMS = 1, WHATS = 2};


    public abstract class FormaEnvio
    {
        public abstract void Enviar(string Aviso);
    }


   public class Email : FormaEnvio
   {
        public override void Enviar(string Aviso)
        {
            //simulando envio de email
            MessageBox.Show("Email enviado: " + Aviso);
        }
   }

    public class SMS : FormaEnvio
    {
        public override void Enviar(string Aviso)
        {
            //simulando envio de email
            MessageBox.Show("SMS enviado: " + Aviso);
        }
    }

    public class WhatsApp : FormaEnvio
    {
        public override void Enviar(string Aviso)
        {
            //simulando envio de email
            MessageBox.Show("WhatsApp enviado: " + Aviso);
        }
    }

    public class Fabrica
    {
        public static FormaEnvio CriarEnvio(TipoEnvio tipo)
        {
            switch (tipo)
            {
                case TipoEnvio.SMS:
                    return new SMS();
                case TipoEnvio.EMAIL:
                    return new Email();
                case TipoEnvio.WHATS:
                    return new WhatsApp();
                default:
                    return null;
            }
        }
    }
}
