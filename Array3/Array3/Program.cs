using System;
using System.Collections.Generic;
using System.Collections;

namespace Array3
{
    class Program
    {
       public static void Main(string[] args)
        {
            Person[] P = new Person[3];
            Person p1 = new Person();
            p1.FirstName = "Aditya";
            p1.LastName = "Ramula";
            p1.Age = 21;
            P[0] = p1;

            Person p2 = new Person();
            p2.FirstName = "Sai";
            p2.LastName = "Krishna";
            p2.Age = 20;
            P[1] = p2;

            Person p3 = new Person();
            p3.FirstName = "Nishanth";
            p3.LastName = "Vemula";
            p3.Age = 23;
            P[2] = p3;
            Console.WriteLine("before sorting ");

            for (int index = 0; index < P.Length; index++)
            {

                Console.WriteLine(P[index].Age);
            }
            P = sortedArray(P);


            Console.WriteLine(" after sorting ");

            for (int index = 0; index < P.Length; index++)
            {
                Console.WriteLine(P[index].Age);
            }

            Console.ReadLine();

        }

        public static Person[] sortedArray(Person[] theArray)
        {
            Array.Sort(theArray);
            return theArray;
        }
    }
}
