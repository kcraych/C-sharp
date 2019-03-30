using System;
using System.Collections.Generic;

namespace Array_and_List_Practice
{
    class Program
    {
        static void Main()
        {
            string[] strArray = { "Amy", "Bob", "Carol", "Dan", "Ellen", "Fred", "Greg", "Holly", "Ivy", "John", "Katie", "Lisa", "Marty", "Ned", "Olivia", "Peter", "Quince", "Ralph", "Sarah", "Tim", "Uma", "Vince", "Walter", "Xenia", "Yvonne", "Zelia" };
            Console.WriteLine("Please select an index of the string array for me to return (integer between 0 and " + (strArray.Length - 1) + ":");
            int index = Convert.ToInt16(Console.ReadLine());
            while (!(index >= 0 && index < strArray.Length))
            {
                Console.WriteLine("You did not choose an index in the proper range between 0 and " + (strArray.Length - 1) + ".  Please try again.");
                index = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(strArray[index]);


            int[] intArray = { 6, 2, 02, -13, 876, 3, 0, -34 };
            Console.WriteLine("\n\nPlease select an index of the integer array for me to return (integer between 0 and " + (intArray.Length - 1) + ":");
            index = Convert.ToInt16(Console.ReadLine());
            while (!(index >= 0 && index < intArray.Length))
            {
                Console.WriteLine("You did not choose an index in the proper range between 0 and " + (intArray.Length - 1) + ".  Please try again.");
                index = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(intArray[index]);


            List<string> strList = new List<string>() { "Amy", "Bob", "Carol", "Dan", "Ellen", "Fred", "Greg", "Holly", "Ivy", "John", "Katie", "Lisa", "Marty", "Ned", "Olivia", "Peter", "Quince", "Ralph", "Sarah", "Tim", "Uma", "Vince", "Walter", "Xenia", "Yvonne", "Zelia" };
            Console.WriteLine("\n\nPlease select an index of the string list for me to return (integer between 0 and " + (strList.Count - 1) + ":");
            index = Convert.ToInt16(Console.ReadLine());
            while (!(index >= 0 && index < strList.Count))
            {
                Console.WriteLine("You did not choose an index in the proper range between 0 and " + (strList.Count - 1) + ".  Please try again.");
                index = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(strList[index]);

            Console.ReadLine();
        }
    }
}