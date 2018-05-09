using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    enum acessorio { Sapato, bolsa, cinto, carteira, colar}
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            string a = "OK";
            long l = 10000;
            float f = 10.89F;
            double d = 550.7552;
            decimal dec = 10.88M;
            bool bl = true;
            char ch = 'X';
            int item = (int)acessorio.cinto;

            //conversao implicita
            int i1 = 10;
            long i2 = i1;

            //conversao explicita
            double d1 = 10.9;
            int d2 = (int)d1;
            
            //int.TryParse("");
            //int.Parse("200");
            //Convert;

            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
