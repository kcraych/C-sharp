using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Practice
{
    class Program
    {
        static void Main()
        {
            //1.Prints the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            //2.Asks the user for a number.
            Console.WriteLine("Please enter a number:");
            double hrs = Convert.ToDouble(Console.ReadLine());

            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine(DateTime.Now.AddHours(hrs));

            Console.ReadLine();
        }
    }
}
