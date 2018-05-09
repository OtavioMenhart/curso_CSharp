using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemIO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("teste1");
            File.AppendAllText(@"C:\1.txt", sb.ToString());

            string[] values = { "linha 1", "linha 2", "linha 3" };
            File.AppendAllLines(@"C:\2.txt", values);

            //File.Copy(@"C:\1.txt", @"C:\3.txt");
            //File.Encrypt(@"C:\3.txt");
            //File.Decrypt(@"C:\3.txt");
        }
    }
}
