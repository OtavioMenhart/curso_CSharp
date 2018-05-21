using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExemploVetores();
            var nums = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var nums2 = new ArrayList() { 21, 22, 23, 24 };
            nums.Add(11);
            nums.Insert(3, 999);
            nums.Remove(4);
            nums[7] = 888;
            nums.AddRange(nums2);
            foreach (var n in nums)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Capacidade: " + nums.Capacity);
            Console.WriteLine("Num itens: " + nums.Count);
            Console.WriteLine("Posição do num 999 no array é: " + nums.IndexOf(999));
            Console.WriteLine("----------------------------------------");

            var qry = from int n in nums where n % 2 == 0 select n;
            foreach (int n in qry)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void ExemploVetores()
        {
            int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
