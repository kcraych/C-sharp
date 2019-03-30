using System;
using System.Text;

namespace String_Practice
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi! What's your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("Welcome, " + fName + "! Let's build a poem together...\n\n");

            StringBuilder poem = new StringBuilder();
            poem.Append("Hey diddle diddle,\n");

            Console.WriteLine("Enter a noun:");
            poem.Append("The " + Console.ReadLine().ToUpper());
            Console.WriteLine("Enter another noun:");
            poem.Append(" and the " + Console.ReadLine().ToUpper() + ",\n");            
            Console.WriteLine("Enter a verb:");
            poem.Append("The cow " + Console.ReadLine().ToUpper() + "\n");
            Console.WriteLine("Enter a preposition:");
            poem.Append(Console.ReadLine().ToUpper());
            Console.WriteLine("Enter a noun:");
            poem.Append(" the " + Console.ReadLine().ToUpper() + ";\n");
            Console.WriteLine("Enter a verb:");
            poem.Append("The little dog " + Console.ReadLine().ToUpper() + "\n");
            Console.WriteLine("Enter a noun:");
            poem.Append("to see such " + Console.ReadLine().ToUpper() + ".\n");
            Console.WriteLine("Enter a verb:");
            poem.Append("And the dish " + Console.ReadLine().ToUpper() + "\n");
            Console.WriteLine("Enter a noun:");
            poem.Append("away with the " + Console.ReadLine().ToUpper());

            Console.Clear();
            Console.WriteLine(poem);

            Console.ReadLine();
        }
    }
}
