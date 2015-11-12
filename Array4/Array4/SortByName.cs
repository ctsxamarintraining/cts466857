using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array4
{
    public class SortByName :IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            if (obj1 is Person && obj2 is Person)
            {
                return (String.Compare(((Person)obj1).name, ((Person)obj2).name));
            }
            throw new ArgumentException("Object is not a person");
        }
    }
}
