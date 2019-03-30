using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Practice
{
    class Program
    {
        static void Main()
        {
            //1.In the Main() method, create a list of at least 10 employees.  Each employee should have a first and last name, as well as an Id.
            //  At least two employees should have the first name "Joe".
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee() {FirstName = "Katie", LastName = "Craychee", Id = 1 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", Id = 2 });
            Employees.Add(new Employee() { FirstName = "Max", LastName = "Washburne", Id = 3 });
            Employees.Add(new Employee() { FirstName = "Brittany", LastName = "Music", Id = 4 });
            Employees.Add(new Employee() { FirstName = "Dan", LastName = "Galemba", Id = 5 });
            Employees.Add(new Employee() { FirstName = "Sarah", LastName = "Romberg", Id = 6 });
            Employees.Add(new Employee() { FirstName = "Jess", LastName = "Hatrak", Id = 7 });
            Employees.Add(new Employee() { FirstName = "Joe", LastName = "Black", Id = 8 });
            Employees.Add(new Employee() { FirstName = "Andy", LastName = "Petty", Id = 9 });
            Employees.Add(new Employee() { FirstName = "Adam", LastName = "Danko", Id = 10 });

            //2.Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> JoeEmployeesForeach = new List<Employee>();
            foreach (Employee emp in Employees)
            {
                if (emp.FirstName == "Joe")
                {
                    JoeEmployeesForeach.Add(emp);
                }
            }

            //3.Do the same thing again, but this time with a lambda expression.
            List<Employee> JoeEmployeesLambda = Employees.Where(x => x.FirstName == "Joe").ToList();

            //4.Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> GT5EmployeesLambda = Employees.Where(x => x.Id > 5).ToList();

            //Console.WriteLine(JoeEmployeesForeach.Count());
            //Console.WriteLine(JoeEmployeesLambda.Count());
            //Console.WriteLine(GT5EmployeesLambda.Count());

            Console.ReadLine();
        }
    }
}
