using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemText_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            StringBuilder sb = new StringBuilder();
            //string a = "new";
            //string b = "york";
            //string c = a + b;
            sb.Append("new");
            sb.Append("york");

            sb.Insert(5, "hello");
            sb.Remove(5, 6);
            sb.Replace('k', 'q');
            //sb.Clear();

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            #endregion



        }
    }
}
