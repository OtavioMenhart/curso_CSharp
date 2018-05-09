using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            int[] a2 = new int[] { 10, 20, 30 };
            string[] a3 = { "um", "dois", "tres" };

            //multidimensional
            int[,] m1 = new int[5, 10];
            m1[0, 0] = 10;

            ArrayList a4 = new ArrayList();
            a4.Add(10);
            a4.Add("OK");
            a4.Add(true);

            //for(int i = 0; i < a1.Length; i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}

            //generics
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(30);

            

            Console.ReadKey();
        }
    }
}
