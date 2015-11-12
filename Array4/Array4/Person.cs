using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array4
{
   public class Person
    {
        public string name { set; get; }
        public int age { set; get; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public static IComparer SortName
        {
            get
            {
                return ((IComparer)new SortByName());
            }
        }
    }
}
