using System;
using System.Collections.Generic;

namespace Iterations_Practice
{
    class Program
    {
        static void Main()
        {
            //1.Create a one-dimensional Array of strings. Ask the user to input some text.
            //  Create a loop that goes through each string in the Array, adding the user’s text to the string.
            //  Then create a loop that prints off each string in the Array on a separate line.
            string[] myGames = { "baseball", "basketball", "football", "tennis", "soccer", "golf" };
            Console.WriteLine("Write one word to describe how you feel about sports which involve balls:");
            string theWord = Console.ReadLine();
            for (int i = 0; i < myGames.Length; i++)
            {
                myGames[i] = myGames[i] + theWord;
                Console.WriteLine(myGames[i]);
            }
            Console.WriteLine("\n\n");

            //2.Create an infinite loop.
            //3.Fix the infinite loop so it will execute.
            for (;;)
            {
                Console.WriteLine("Test 1 iteration before breaking infinite loop");
                break;
            }
            Console.WriteLine("\n\n");

            //4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");

            //5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\n");

            //6.Create a List of strings where each item in the list is unique.  Ask the user to select text to search for in the List.
            //  Create a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            //8.Add code to that above loop that stops it from executing once a match has been found.
            List<string> myAnimals = new List<string>() { "Pig", "Cow", "Chicken", "Cat", "Dog", "Horse", "Goat" };
            Console.WriteLine("I own 7 animals.  They are all a distinct type of animal that you might find on a farm.  Guess an animal (singular) to see if it's one I own!");
            string animalGuess = Console.ReadLine();
            int counter = 0;
            foreach (string animal in myAnimals)
            {
                if (animalGuess.ToUpper() == animal.ToUpper())
                {
                    Console.WriteLine("Yes, I do own a " + animal + "!  It is animal #" + myAnimals.IndexOf(animal) + ".");
                    counter += 1;
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("I do not own a " + animalGuess + ".");
            }
            Console.WriteLine("\n\n");

            //9.Create a List of strings that has at least two identical strings in the List. 
            //  Ask the user to select text to search for in the List.
            //  Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.
            List<string> myPurse = new List<string>() { "Wallet", "Cellphone", "Chapstick", "Key", "Flashlight", "Chapstick", "Umbrella", "Gum", "Pen" };
            Console.WriteLine("I took an inventory of everything in my purse.  See if you can guess one of the items (which I may have more than one of)!");
            string itemGuess = Console.ReadLine();
            counter = 0;
            int index = 0;
            foreach (string item in myPurse)
            {
                if (itemGuess.ToUpper() == item.ToUpper())
                {
                    Console.WriteLine(item + " = index #" + index);
                    counter += 1;
                }
                index += 1;
            }
            if (counter == 0)
            {
                Console.WriteLine("There is not a " + itemGuess + " in my purse.");
            }
            Console.WriteLine("\n\n");

            //11.Create a List of strings that has at least two identical strings in the List. 
            //   Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string> myProduce = new List<string>() { "Apple", "Apple", "Potato", "Broccoli", "Orange", "Apple", "Potato", "Orange", "Lettuce" };
            List<string> unqProduce = new List<string>();
            List<int> cntProduce = new List<int>();
            foreach (string produce in myProduce)
            {
                if (unqProduce.Contains(produce))
                {
                    cntProduce[unqProduce.IndexOf(produce)] += 1; 
                } else
                {
                    unqProduce.Add(produce);
                    cntProduce.Add(1);
                }
                Console.WriteLine(produce + ": has appeared in list " + cntProduce[unqProduce.IndexOf(produce)] + " time(s).");
            }
           

            Console.ReadLine();
        }
    }
}
