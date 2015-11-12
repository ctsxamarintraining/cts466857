using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            Console.WriteLine("value of nullable integer is {0}",nullableInteger);
            nullableInteger = 3;
            Console.WriteLine("value of nullable integer after assigning value is {0}",nullableInteger);
            Console.ReadLine();
        }
    }
}
