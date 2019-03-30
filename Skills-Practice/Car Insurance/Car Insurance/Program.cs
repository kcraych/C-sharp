using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (please enter true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            short speeding = Convert.ToInt16(Console.ReadLine());

            bool qualify = (age > 15) && (dui == false) && (speeding <= 3);
            Console.WriteLine("Qualified? \n" + qualify);
            Console.ReadLine();
        }
    }
}
