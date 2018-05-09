using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace SystemResources_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Resources.ResourceManager rm = new ResourceManager(typeof(SystemResources_Examples.Main));
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
            string d = rm.GetString("DESCRICAO", ci);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
