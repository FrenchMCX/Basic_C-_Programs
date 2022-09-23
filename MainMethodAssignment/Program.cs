using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate methods
            Methods methods = new Methods();

            //Ask for input
            Console.WriteLine("Insert a number to add 7 to, a decimal to add 7.7 to, and a string to add 7 to.");
            int input = Convert.ToInt32(Console.ReadLine());
            double input1 = Convert.ToDouble(Console.ReadLine());
            string input2 = Console.ReadLine();
            //Call methods
            int result1 = methods.addSeven(input);
            int result2 = methods.addSeven(input1);
            int result3 = methods.addSeven(input2);

            //Print results
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
