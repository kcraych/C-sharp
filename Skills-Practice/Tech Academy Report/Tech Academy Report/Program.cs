using System;

namespace TechAcademyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report \n");

            Console.WriteLine("\n What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("\n What page number?");
            string coursePageStr = Console.ReadLine();
            short coursePage = Convert.ToInt16(coursePageStr);

            Console.WriteLine("\n Do you need help with anything? Please answer “true” or “false”.");
            string helpNeededStr = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(helpNeededStr);

            Console.WriteLine("\n Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();

            Console.WriteLine("\n Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("\n How many hours did you study today?");
            string hrsStudyStr = Console.ReadLine();
            short hrsStudy = Convert.ToInt16(hrsStudyStr);

            Console.WriteLine("\n \n Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
