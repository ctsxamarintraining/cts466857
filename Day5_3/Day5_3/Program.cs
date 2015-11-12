using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_3
{
    class Program
    {
        public delegate void DelegateMethod();
        static void Main(string[] args)
        {
            DelegateMethod dm = delegate
            {
                Console.WriteLine("Anonymous Method");
            };
            dm();
            Console.ReadLine();

        }
    }
}
