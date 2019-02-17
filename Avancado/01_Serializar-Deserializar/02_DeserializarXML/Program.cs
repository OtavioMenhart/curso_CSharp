using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            StreamReader stream = new StreamReader(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\01_Serializar-Deserializar\Arquivos\01_SerializarXML.xml");

            Usuario usuario = (Usuario) serializador.Deserialize(stream);
            Console.WriteLine(usuario.Nome + "\n" + usuario.CPF + "\n" + usuario.Email);
            Console.ReadKey();
        }
    }
}
