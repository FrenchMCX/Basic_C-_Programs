using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate methods
            Methods methods = new Methods();

            //Ask for and receive input
            Console.WriteLine("What number would you like to add 7 to, subtract 7 from and multiply by 7?");
            int input = Convert.ToInt32(Console.ReadLine());

            //Call methods
            int result = methods.addSeven(input);
            int result1 = methods.subtractSeven(input);
            int result2 = methods.multiplySeven(input);

            //Print results
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
