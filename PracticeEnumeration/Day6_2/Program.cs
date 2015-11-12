using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
    {
        
    }
}
