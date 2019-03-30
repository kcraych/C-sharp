using System;
using System.Text;

namespace Math_Practice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number, and I will multiple it by 50:");
            decimal num1 = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine(num1 + " * 50 = " + num1 * 50);

            Console.WriteLine("\n Enter a number, and I will add 25 to it:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            decimal sum25 = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + sum25);

            Console.WriteLine("\n Enter a number, and I will divide it by 12.5:");
            decimal num3 = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine(num3 + " / 12.5 = " + num3 / (decimal)12.5);

            Console.WriteLine("\n Enter a number, and I tell you if it is greater than 50:");
            decimal num4 = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine(num4 + " > 50?: " + (num4 > 50));

            Console.WriteLine("\n Enter a number, and I will tell you the remainder after division by 7:");
            decimal num5 = Convert.ToDecimal(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine(num5 + " / 7 leaves a remainder of " + num5 % 7);
            Console.ReadLine();
        }
    }
}
