using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEnumerable me = new MyEnumerable();
            var EnObj = me.GetEnumerator();
            while (EnObj.MoveNext())
            {
                Console.WriteLine(EnObj.Current);
            }
            Console.ReadLine();
        }
    }
    public class MyEnumerator : IEnumerator
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int currentIndex = -1;

        public object Current
        {

            get
            {
                if (a[currentIndex] % 2 == 0)
                {
                    return a[currentIndex];
                }
                else return null;
               // throw new NotImplementedException(); 
            }
        }

        public bool MoveNext()
        {
            if (a.Length - 1 > currentIndex)
            {
                currentIndex++;
                return true;
            }
            else
                return false;
           // throw new NotImplementedException();
        }

        public void Reset()
        {
            currentIndex = -1;
           // throw new NotImplementedException();
        }
    }

    public class MyEnumerable : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator();
           // throw new NotImplementedException();
        }
    }
}
