using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[4]{1,2,3,4};
            try
            {
                int i = 4;
                while (true)
                {
                    Console.Write("Please Add number to the array: ");
                    intArray[i] = int.Parse(Console.ReadLine());
                    i++;
                }
            }
            catch (IndexOutOfRangeException outofrangeex)
            {
                string s = string.Empty;
                int k=0;
                foreach (int i in intArray)
                {
                    
                    s += i.ToString() + ",";
                    k++;

                   // Console.Write(i + ",");
                }
                s.Remove(s.Length - 1);
                Console.WriteLine("Numbers in array is {0} ",s);

                Console.WriteLine("\n\n\nException..{0} \n\n\n Check the size of array", outofrangeex);
            }
            catch (FormatException formatex)
            {
                Console.WriteLine("\n\n\nException..{0} \n\n\n Give proper input", formatex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\n\nException..{0} \n\n\n",ex);
            }
            Console.ReadLine();
        }
    }
}
