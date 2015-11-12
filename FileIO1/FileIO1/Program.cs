using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("File1.txt"))
            {
                sw.WriteLine("First");
                sw.WriteLine("Second");
                sw.WriteLine("Third");
            }
            Console.WriteLine("Source File is..");

            using (StreamReader sr = new StreamReader("File1.txt"))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            List<string> lines = new List<string>();
            using (StreamReader source_StreamReader = new StreamReader("File1.txt"))
            {
                string line;
                while ((line = source_StreamReader.ReadLine()) != null)
                {
                  //  Console.WriteLine(line);
                    lines.Add(line);
                }
            }

            lines.Reverse();
            using (StreamWriter sw2 = new StreamWriter("File2.txt"))
            {
                foreach (string l in lines)
                {
                    sw2.WriteLine(l);
                }
            }
            Console.WriteLine("Destination File is..");
            using (StreamReader sr2 = new StreamReader("File2.txt"))
            {
                
                Console.WriteLine(sr2.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
