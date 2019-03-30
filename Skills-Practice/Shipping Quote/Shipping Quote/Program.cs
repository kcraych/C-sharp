using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            double ttlDim = width + length + height;

            if (ttlDim > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            } else
            {
                double quote = (ttlDim * weight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + Math.Round(quote,2));
            }

            Console.ReadLine();
        }
    }
}
