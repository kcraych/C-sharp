using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
            //2. In the Main() method, create an object of data type Number and assign an amount to it.
            //3. Print this amount to the console.

            Number num1 = new Number();
            num1.Amount = 11.13m;
            Console.WriteLine(num1.Amount);

            //Number num2 = num1;
            //num2.Amount = 50;
            //Console.WriteLine(num2.Amount);

            Console.ReadLine();
        }
    }
}
