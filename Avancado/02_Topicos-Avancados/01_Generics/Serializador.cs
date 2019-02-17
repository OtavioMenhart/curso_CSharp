using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            string nomeDaClasse = obj.GetType().Name;
            StreamWriter sw = new StreamWriter(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\02_Topicos-Avancados\Arquivos\02_" + nomeDaClasse + ".txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            string nomeDaClasse = typeof(T).Name;
            StreamReader sr = new StreamReader(@"C:\Users\otavi\OneDrive\Documentos\ESTUDO\C# Avancado\02_Topicos-Avancados\Arquivos\02_" + nomeDaClasse + ".txt");

            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer deserializar = new JavaScriptSerializer();
            T obj = (T)deserializar.Deserialize(conteudo, typeof(T));

            return obj;
        }
    }
}
