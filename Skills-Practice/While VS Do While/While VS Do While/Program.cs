using System;

namespace While_VS_Do_While
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the HIGHER or LOWER guessing game!");
            Console.WriteLine("How many tries does it take YOU to guess the chosen whole number between 1 and 500? \n");

            short theNum = 83;

            Console.WriteLine("What's your first guess?");
            short theGuess = Convert.ToInt16(Console.ReadLine());

            bool winning = false;
            int counter = 0;

            //do while loop to tell user whether their guess was high, low, or correct
            do
            {
                counter += 1;
                if (theGuess == theNum)
                {
                    int i = 1;
                    Console.Clear();

                    //regular while look to count down the number of guesses it took the user to win
                    while (i < counter)
                    {
                        Console.WriteLine("It took you " + i + ((i == 1 ? " try" : " tries")) + "...");
                        i += 1;
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("It took you " + i + ((i == 1 ? " try" : " tries")) + " to guess the  chosen number " + theNum + " and become a WINNER!");
                    winning = true;
                } else if (theGuess < theNum)
                {
                    Console.WriteLine("\n The chosen number is higher than your guess of " + theGuess +".");
                    Console.WriteLine("What's your next guess?");
                    theGuess = Convert.ToInt16(Console.ReadLine());
                } else if (theGuess > theNum)
                {
                    Console.WriteLine("\n The chosen number is lower than your guess of " + theGuess + ".");
                    Console.WriteLine("What's your next guess?");
                    theGuess = Convert.ToInt16(Console.ReadLine());
                } else
                {
                    Console.WriteLine("\n EEK!  Something went wrong.");
                    theGuess = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (!winning);
            Console.ReadLine();
        }
    }
}
