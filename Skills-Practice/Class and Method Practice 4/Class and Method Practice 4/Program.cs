﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a class. In that class, create a method that takes two integers as parameters.  Make one of them optional.
            //   Have the method do a math operation and return a integer result.
            //2. In the Main() method of the console app, instantiate the class.
            //3. Ask the user to input two numbers, one at a time.  Let them know they need not enter anything for the second number.
            //4. Call the method in the class, passing in the one or two numbers entered.
            //5. Try various combinations of numbers on the code, including having no second number.

            MyClass myObject = new MyClass();
            Console.WriteLine("Please enter an integer!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another integer or simply hit enter (to forgo entering a second integer");
            string num2str = Console.ReadLine();
            if (!string.IsNullOrEmpty(num2str))
            {
                int num2 = Convert.ToInt32(num2str);
                Console.WriteLine(myObject.MyMethod(num1, num2));
            } else
            {
                Console.WriteLine(myObject.MyMethod(num1));
            }
         
            Console.ReadLine();

        }
    }
}
