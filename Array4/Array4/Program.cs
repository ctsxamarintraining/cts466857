using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    class Program
    {
       public static void Main(string[] args)
        {
            
			Person[] pArray = new Person[3];	
            pArray [0] = new Person( "Adithya", 21 );		
            pArray [1] = new Person("Sai", 23 );		
            pArray [2] = new Person( "Nishanth", 22 );		
           
            Array.Sort(pArray, Person.SortName);	
            for (int i = 0; i < pArray.Length; i++) {	
                Console.WriteLine (pArray[i].name);	
            }
            Console.ReadLine();
        }
    }
}
