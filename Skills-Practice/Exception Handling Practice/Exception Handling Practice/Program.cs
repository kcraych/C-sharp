using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Practice
{
    class Program
    {
        static void Main()
        {
            //1.Ask the user for his age.
            //2.Display the year user born.
            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.

            bool runcheck = false;
            while (!runcheck)
            {
                try
                {
                    int age;
                    Console.WriteLine("Please enter your age:");
                    bool ageValid = int.TryParse(Console.ReadLine(), out age);
                    if (!ageValid || age <= 0 || age > 130) throw new ArgumentException();
                    int yrDOB = DateTime.Now.AddYears(-age).Year;
                    Console.WriteLine("Your DOB year is {0}", yrDOB);
                    runcheck = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an age representing how many years old you are, using a positive number, digits only, and no decimals.");
                }
                catch (Exception)
                {
                    Console.WriteLine("There has been a fatal error.  Please contact your system administrator.");
                    runcheck = true;
                }
            }
            Console.ReadLine();
        }
    }
}
