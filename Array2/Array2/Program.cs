using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 2] {{1,2},{3,4}};
            Print_array(array);
            Console.ReadLine();
        }
        static void Print_array(Array theArray)
        {
            foreach(var i in theArray)
                Console.WriteLine(i);
        }
    }
}
