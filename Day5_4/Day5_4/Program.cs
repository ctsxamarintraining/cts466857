using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_4
{
    class Program
    {
       public static void Main(string[] args)
        {
            List<PersonDetails> PersonList = new List<PersonDetails>
            {
                new PersonDetails{ ID=1 , Name = "Aditya" , City="Hyderabad"},
                new PersonDetails{ ID=2 , Name = "Sai" , City="Khammam"},
                new PersonDetails{ ID=3 , Name = "Vinay" , City="Secunderabad"}
            };
            foreach (PersonDetails aPerson in PersonList)
            {
                Console.WriteLine("Name of the person is {0}, ID is {1}, City is {2}",aPerson.Name,aPerson.ID,aPerson.City);
            }
            Console.ReadLine();
        }
    }

    public class PersonDetails
    {
        public int ID;
        public string Name;
        public string City;
    }
}
