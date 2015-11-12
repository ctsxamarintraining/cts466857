﻿using System;

namespace Array3
{
   public class Person : IComparable
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                return this.Age.CompareTo((obj as Person).Age);  
            }
            throw new ArgumentException("Object is not person");
        }
    }
}
