﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Practice
{
    class Program
    {
        static void Main()
        {
            //1. Create an enum for the days of the week.
            //2. Prompt the user to enter the current day of the week.
            //3. Assign the value to a variable of that enum data type you just created.
            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

            Console.WriteLine("Please enter the current day of the week: ");

            bool input = false;
            while (input == false) 
            {
                try
                {
                    Weekdays today = (Weekdays)Enum.Parse(typeof(Weekdays), Console.ReadLine(), true);
                    Console.WriteLine("You think tooday is: {0}", today.ToString());
                    input = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please enter an actual day of the week:");
                }
            }

            Console.ReadLine();
        }

        public enum Weekdays { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
    }
}
