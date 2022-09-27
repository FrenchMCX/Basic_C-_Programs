using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string DayOfTheWeekInput = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), DayOfTheWeekInput);
                Console.WriteLine("Yes, today is " + day);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            } 

            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
