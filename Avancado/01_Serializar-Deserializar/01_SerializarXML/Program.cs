using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Otávio", CPF = "222222222-22", Email = "otavio@gmail.com"};
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            //XmlSerializer serializador = new XmlSerializer(usuario.GetType());

            StreamWriter stream = new StreamWriter(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\01_Serializar-Deserializar\Arquivos\01_SerializarXML.xml");

            serializador.Serialize(stream, usuario);
        }
    }
}
