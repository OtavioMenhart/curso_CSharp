using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Maria", CPF = "333.333.333-33", Email = "maria@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObj = serializador.Serialize(usuario);

            StreamWriter stream = new StreamWriter(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\01_Serializar-Deserializar\Arquivos\02_SerializarJSON.json");
            stream.WriteLine(stringObj);
            stream.Close();
        }
    }
}
