using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            //   The methods should do some math operation on the received parameter.  Put this class in a separate.cs file in the application.
            //2. In the Main() program, ask the user what number they want to do the math operations on.
            //3. Call each method in turn, passing the user input to the method.  Display the returned integer to the screen.

            Console.WriteLine("Enter an integer so I can some awesome arithmetic!");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result from the Add5 method: " + Arithmetic.Add5(input));
            Console.WriteLine("Result from the Subtract10 method: " + Arithmetic.Subtract10(input));
            Console.WriteLine("Result from the Multiply2 method: " + Arithmetic.Multiply2(input));
            Console.ReadLine();
        }
    }
}
