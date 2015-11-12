using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[, , ,] array4D;
            array4D = new int[2, 2, 2, 2]{{{{1,2},{3,4}},{{5,6},{7,8}}},{{{9,10},{11,12}},{{13,14},{15,16}}}};
           
            foreach(int i in array4D){
                Console.WriteLine("{0}",i);
            }
            Console.ReadLine();
        }
    }
}
