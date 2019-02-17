using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods
{
    public static class StringExtension
    {
        public static string FirstToUpper(this String str)
        {
            string first = str.Substring(0, 1).ToUpper();
            //first.ToUpper();

            string second = str.Substring(1);
            string result = first + second;
            return result;
        }
    }
}
