using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace _04_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            JavaScriptSerializer serializador = new JavaScriptSerializer();

            StreamReader stream = new StreamReader(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\01_Serializar-Deserializar\Arquivos\02_SerializarJSON.json");
            string linhasArquivo = stream.ReadToEnd();
            Usuario usuario = (Usuario) serializador.Deserialize(linhasArquivo, typeof(Usuario));

            Console.WriteLine(usuario.Nome + "\n" + usuario.CPF + "\n" + usuario.Email);
            Console.ReadKey();
        }
    }
}
