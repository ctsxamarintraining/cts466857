using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("Number of Words is {0} \nNumber of Charecters is {1}",s.Numberofwords(),s.NumberofChars());
            Console.ReadLine();
        }
    }
}
