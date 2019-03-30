using System;
using System.Collections.Generic;

namespace Error_Handling_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a list of integers. Ask the user for a number to divide each number in the list by.
            //  Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
            //2.Run that code, entering in non - zero numbers as the user.  Look at the displayed results.
            //3.Run that code, entering in zero as the number to divide by.  Note any error messages you get.
            //4.Run that code, entering in a string as the number to divide by.  Note any error messages you get.
            //5.Now put the loop in a try/catch block.  Below and outside of the try/catch block, make the program display a message to the display 
            //  to let you know the program has emerged from the try/catch block and continued on with program execution.  In the catch block, 
            //  display the error message to the screen.  Then try various combinations of user input: valid numbers, zero and a string.
            //  Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            bool executed = false;
            while (executed == false) {
                try
                {
                    List<int> intList = new List<int>() { 6, 0, 1, 10, 5000 };
                    Console.WriteLine("Please enter a number which I can use for division:");
                    double theNum = Convert.ToDouble(Console.ReadLine());
                    foreach (int num in intList)
                    {
                        double divNum = (theNum == 0) ? num / (int)theNum : num / theNum;
                        Console.WriteLine(num + " / " + theNum + " = " + divNum);
                    }
                    executed = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot divide by 0.  Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "  Try again.");
                }
            }
            Console.WriteLine("\nThis program has finished executing.");
            Console.ReadLine();
        }
    }
}
