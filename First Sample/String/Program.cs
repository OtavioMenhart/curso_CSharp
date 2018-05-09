using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "um";
            string s2 = "dois";
            s2 += ", tres";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("um");
            sb.Append(", dois");

            s2.EndsWith("ree");
            s2.Equals("");
            s2.IndexOf("two");
            sb.ToString();
            s2.Insert(4, "OK");
            s2.Remove(4, 5);
            s2.Replace("two", "one");
            s1.Split(',');

        }
    }
}
