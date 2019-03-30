using System;

namespace Salary_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine("Hours worked per week?");
            double weeklyHours1 = Convert.ToDouble(Console.ReadLine().Replace(",", string.Empty));
            double weeklySalary1 = Math.Round(hourlyRate1 * weeklyHours1,2);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine().Replace(",", string.Empty));
            Console.WriteLine("Hours worked per week?");
            double weeklyHours2 = Convert.ToDouble(Console.ReadLine().Replace(",", string.Empty));
            double weeklySalary2 = Math.Round(hourlyRate2 * weeklyHours2, 2);

            Console.WriteLine("Weekly salary of Person 1: \n" + weeklySalary1);
            Console.WriteLine("Weekly salary of Person 2: \n" + weeklySalary2);
            Console.WriteLine("Does Person 1 make more money than Person 2? \n" + (weeklySalary1 > weeklySalary2));
            Console.ReadLine();
        }
    }
}
