using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport.cs
{
    internal class Program
    {
        static void Main()
        {
            //Initial messages
            Console.WriteLine("The Tech Academy \n");
            Console.WriteLine("Student Daily Report \n");
            //declare string name
            Console.WriteLine("What is your name? \n");
            string name = Console.ReadLine();
            Console.WriteLine("\n");
            //declare string course
            Console.WriteLine("What course are you on? \n");
            string course = Console.ReadLine();
            Console.WriteLine("\n");
            //declare string page
            Console.WriteLine("What page number? \n");
            string page = Console.ReadLine();
            //convert string to int
            int pageNumber = Convert.ToInt32(page);
            Console.WriteLine("\n");
            //declare string help
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            //convert string to boolean
            bool needHelp = Convert.ToBoolean(help);
            Console.WriteLine("\n");
            //declare string posFeedback
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics. \n");
            string posFeedback = Console.ReadLine();
            Console.WriteLine("\n");
            //declare string feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific. \n");
            string feedback = Console.ReadLine();
            Console.WriteLine("\n");
            //declare string hours
            Console.WriteLine("How many hours did you study today? \n");
            string hours = Console.ReadLine();
            // convert string to int
            int hourCount = Convert.ToInt32(hours);
            Console.WriteLine("\n");
            //Thank you message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");


            Console.Read();
        }
    }
}
