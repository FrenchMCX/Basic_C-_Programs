using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment_CalculateNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string timesFifty;
            long timesFiftyLong;
            //Ask for input
            Console.WriteLine("Enter a number to multiply by 50 - ");
            //Read input
            timesFifty = Console.ReadLine();
            //Convert string to long
            timesFiftyLong = Convert.ToInt64(timesFifty);
            //Multiply long by 50
            long timesFiftyLongResult = timesFiftyLong * 50;
            //Return result
            Console.WriteLine(timesFiftyLongResult + "\n");

            //Declare variables
            string plus25;
            long plus25Long;
            //Ask for input
            Console.WriteLine("Enter a number to add 25 to - ");
            //Read input
            plus25 = Console.ReadLine();
            //Convert string to long
            plus25Long = Convert.ToInt64(plus25);
            //Add 25 to long
            long plus25LongResult = plus25Long + 25;

            Console.WriteLine(plus25LongResult + "\n");

            string divide12Point5;
            double divide12PointFive;
            Console.WriteLine("Enter a number to divide by 12.5 - ");
            divide12Point5 = Console.ReadLine();
            divide12PointFive = Convert.ToDouble(divide12Point5);
            double divide12PointFiveResult = divide12PointFive / 12.5;
            Console.WriteLine(divide12PointFiveResult + "\n");

            string greaterFifty;
            long greaterFiftyLong;
            Console.WriteLine("Enter a number. Then I'll check if its greater than 50 and return true or false - ");
            greaterFifty = Console.ReadLine();
            greaterFiftyLong = Convert.ToInt64(greaterFifty);
            bool greaterFiftyBoolean = greaterFiftyLong > 50;
            Console.WriteLine(greaterFiftyBoolean + "\n");

            string remainder;
            double remainderSeven;
            Console.WriteLine("Enter a number to divide by 7. Then I'll return the remainder - ");
            remainder = Console.ReadLine();
            remainderSeven = Convert.ToDouble(remainder);
            double remainderSevenResult = remainderSeven % 7;
            Console.WriteLine(remainderSevenResult + "\n");

            Console.Read();
        }
    }
}
