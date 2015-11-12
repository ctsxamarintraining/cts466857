using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Path");
            string path = Console.ReadLine();
            if (!File.Exists(path))
            {
                
                throw new FileDoesnotExistsException("No File Found");
            }
            else if (File.Exists(path))
            {
                string readText = File.ReadAllText(path);
                if (readText == string.Empty)
                {
                    throw new EmptyFileException("File is Empty");
                }
                else
                {
                    Console.WriteLine("Contents is the File is \n{0}",readText);
                    Console.ReadLine();
                }
            }

            
            

        }
    }
    public class FileDoesnotExistsException : ApplicationException
    {
        public FileDoesnotExistsException(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
    public class EmptyFileException : ApplicationException
    {
        public EmptyFileException(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
