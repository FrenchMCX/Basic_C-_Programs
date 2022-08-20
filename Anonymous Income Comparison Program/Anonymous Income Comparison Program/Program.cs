using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program title message
            Console.WriteLine("Anonymous Income Comparison Program \n");


            //Declare person 1
            Console.WriteLine("Person 1 \n");
            //Declare variables
            string hourlyRate;
            int hourlyRateInt;
            //Ask for input
            Console.WriteLine("Please enter the hourly rate: \n");
            hourlyRate = Console.ReadLine();
            Console.WriteLine("\n");
            //Convert string to int
            hourlyRateInt = Convert.ToInt32(hourlyRate);
            //Declare variables
            string hoursWorked;
            int hoursWorkedInt;
            //Ask for input
            Console.WriteLine("Please enter the weekly hours worked: \n");
            hoursWorked = Console.ReadLine();
            Console.WriteLine("\n");
            //Convert string to int
            hoursWorkedInt = Convert.ToInt32(hoursWorked);

            //Declare person 2
            Console.WriteLine("Person 2 \n");
            //Declare variables
            string hourlyRate2;
            int hourlyRateInt2;
            //Ask for input
            Console.WriteLine("Please enter the hourly rate: \n");
            hourlyRate2 = Console.ReadLine();
            Console.WriteLine("\n");
            //Convert string to int
            hourlyRateInt2 = Convert.ToInt32(hourlyRate2);
            //Declare variables
            string hoursWorked2;
            int hoursWorkedInt2;
            //Ask for input
            Console.WriteLine("Please enter the weekly hours worked: \n");
            hoursWorked2 = Console.ReadLine();
            Console.WriteLine("\n");
            //Convert string to int
            hoursWorkedInt2 = Convert.ToInt32(hoursWorked2);

            //Declare salary 1 and calculate salary 1
            int salary1 = hourlyRateInt * hoursWorkedInt * 52;
            //Print salary 1
            Console.WriteLine("Annual salary of Person 1: " + salary1 + "\n");
            //Declare salary 2 and calculate salary 2
            int salary2 = hourlyRateInt2 * hoursWorkedInt2 * 52;
            //Print salary 2
            Console.WriteLine("Annual salary of Person 2: " + salary2 + "\n");

            //Declare and calculate boolean comparison
            bool comparison = salary1 > salary2;
            //Print comparison
            Console.WriteLine("Does Person 1 make more money than person 2? \n" + comparison);

            Console.Read();
        }
    }
}
