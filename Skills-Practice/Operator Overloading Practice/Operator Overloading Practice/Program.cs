using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading_Practice
{
    class Program
    {
        static void Main()
        {
            //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            Employee emp1 = new Employee() { FirstName = "Sample", LastName = "Employee1", Id = 1, isActive = true };
            Employee emp2 = new Employee() { FirstName = "Sample", LastName = "Employee2", Id = 2, isActive = true };
            Employee emp3 = new Employee() { FirstName = "Sample", LastName = "Employee3", Id = 1, isActive = true };

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 == emp3);
            Console.WriteLine(emp2 == emp3);

            Console.ReadLine();

        }
    }
}
