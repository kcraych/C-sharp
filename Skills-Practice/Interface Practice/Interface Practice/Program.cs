using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create an interface called IQuittable and have it define a void method called Quit().
            //2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
            //3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //   Hint: an object can be of an interface type if it implements that specific interface.

            IQuittable employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.Quit();

            //CLARIFYING QUESTION:
            //When using polymorphism (if I'm doing this right), it seems like you lose access to the properties of the Employee class.  
                //---Is that accurate?  I ask because I'm finding I can't run the below commented out line when I instantiate my employee object like I did above (line 18).
                //Console.WriteLine("{0} {1} is an active employee: {2}", employee.FirstName, employee.LastName, employee.isActive);
            
            //However, when if I write the code like below, I can access the properties of the Employee class, PLUS the quit method.  
                //---Did I interpret the use of polymorphism correctly above?  
                //---Is there a reason you would use the polymorphism here over straight Employee class, or was it just to show understanding of how to do it, generally speaking?
            Employee employee2 = new Employee() { FirstName = "Test", LastName = "Scenario" };
            Console.WriteLine("{0} {1} is an active employee: {2}", employee2.FirstName, employee2.LastName, employee2.isActive);
            employee2.Quit();
            Console.WriteLine("{0} {1} is an active employee: {2}", employee2.FirstName, employee2.LastName, employee2.isActive);

            Console.ReadLine();
        }
    }
}
