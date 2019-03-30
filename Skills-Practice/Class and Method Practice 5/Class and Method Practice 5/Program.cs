using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a class. In that class, create a void method that outputs an integer.  Have the method divide the data passed to it by 2.
            //2. In the Main() method, instantiate that class.
            //3. Have the user enter a number.  Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.
            //4. Create a method with output parameters.
            //5. Overload a method.
            //6. Declare a class to be static.

            myClass myObject = new myClass();
 
            Console.WriteLine("Please enter an integer!");
            int input = Convert.ToInt32(Console.ReadLine());

            //output parameter version
            int outResult;
            myObject.myMethod(input, out outResult);
            Console.WriteLine(outResult);

            //overloading + static version
            myClass.myMethod(input);
            Console.WriteLine(outResult);

            Console.ReadLine();
        }
    }
}
