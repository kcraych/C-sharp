using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Practice
{
    class Program
    {
        static void Main()
        {
            //1. Make the Employee class take a generic type parameter.
            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
            //3. Instantiate an Employee object with type "string" as its generic parameter.  Assign a list of strings as the property value of Things.
            //4. Instantiate an Employee object with type "int" as its generic parameter.  Assign a list of integers as the property value of Things.
            //5. Create a loop that prints all of the Things to the Console.

            Employee<dynamic> emp1 = new Employee<dynamic>();
            emp1.Things = new List<dynamic>() { "I", "Am", "A", "List", "Of", "Strings" };

            Employee<dynamic> emp2 = new Employee<dynamic>();
            emp2.Things = new List<dynamic>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var Employees = new List<List<dynamic>>();
            Employees.Add(emp1.Things);
            Employees.Add(emp2.Things);

            foreach (List<dynamic> y in Employees)
            {
                foreach (dynamic x in y)
                {
                    Console.WriteLine(x);
                }
            }

            Console.ReadLine();
        }
    }
}
