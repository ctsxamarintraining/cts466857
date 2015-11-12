using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Example\myexample.txt";

            try
            {
                if (!File.Exists(path))
                {
                    throw new FiledoesnotExistsException("File Not founded"
                    // Create a file to write to.
                   // string createText = "Hello and Welcome" + Environment.NewLine;
                   // File.WriteAllText(path, createText);
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
    public class FiledoesnotExistsException : ApplicationException
    {
        public FiledoesnotExistsException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
