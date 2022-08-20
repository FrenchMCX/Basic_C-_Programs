using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine(total);
            int otherTotal = 12 + 22;
            Console.WriteLine(otherTotal);
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            

            int difference = 10 - 5;
            Console.WriteLine(difference);
            

            int product = 10 * 5;
            Console.WriteLine(product);
            

            int quotient = 100 / 5;
            Console.WriteLine(quotient);

            int remainder = 3 % 2;
            Console.WriteLine(remainder);

            bool trueorFalse = 12 > 5;
            Console.WriteLine(trueorFalse.ToString());

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine(isWarm);


            Console.ReadLine();

        }
    }
}
