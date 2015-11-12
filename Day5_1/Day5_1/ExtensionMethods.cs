using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1
{
    public static class ExtensionMethods
    {
        public static int Numberofwords(this string str)
        {
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            return (str.Split(' ')).Length;
            
        }

        public static int NumberofChars(this string str)
        {
            while (str.Contains(" "))
            {
                str = str.Replace(" ", "");
            }
            return str.Length;
        }

    }
}
