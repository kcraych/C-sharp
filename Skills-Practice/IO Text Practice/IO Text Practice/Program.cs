using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Text_Practice
{
    class Program
    {
        static void Main()
        {
            //1.Ask a user for a number.
            Console.WriteLine("Please enter a number.");
            string numWrite = Console.ReadLine();

            //2.Log that number to a text file.
            string filePath = @"C:\Users\kcraychee\Desktop\log_practice.txt";
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(numWrite);
            }

            //3.Print the text file back to the user.
            string numRetrieve = File.ReadAllText(filePath);
            Console.WriteLine(numRetrieve);
        }
    }
}
