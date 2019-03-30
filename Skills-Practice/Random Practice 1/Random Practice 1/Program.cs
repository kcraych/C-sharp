using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Practice_1
{
    class Program
    {
        static void Main()
        {
            //1. Create a const variable.
            const string iAmConstant = "I am constant.";

            //2. Create a variable using the keyword "var".
            var myList = new List<string>() { "I", "am", "a", "string", "list" };

            //3. Chain two constructors together.
            Dog dog1 = new Dog("Rover", "Lab");
            Dog dog2 = new Dog("Boomer");

            Console.WriteLine("Regular constructor: name = {0}, breed = {1}", dog1.Name, dog1.Breed);
            Console.WriteLine("Chained constructor: name = {0}, breed = {1}", dog2.Name, dog2.Breed);
            Console.ReadLine();
        }
    }
}
