using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int k = 0;
            try
            {
                 k = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("answ is {0}", Math.Sqrt(k));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
            Console.ReadLine();


        }
    }
}
