using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express_Quote_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write program title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n");
            //Declare variables, ask for input, then convert string to int
            string packageWeight;
            Console.WriteLine("What is the package weight? \n");
            int packageWeightInt = Convert.ToInt32(Console.ReadLine());

            bool weightLimit = packageWeightInt > 50;
            
            //Declare variables, ask for input, then convert string to int
            string packageWidth;
            Console.WriteLine("What is the package width? \n");
            int packageWidthInt = Convert.ToInt32(Console.ReadLine());

            //Declare variables, ask for input, then convert string to int
            string packageHeight;
            Console.WriteLine("What is the package height? \n");
            int packageHeightInt = Convert.ToInt32(Console.ReadLine());

            //Declare variables, ask for input, then convert string to int
            string packageLength;
            Console.WriteLine("What is the package length? \n");
            int packageLengthInt = Convert.ToInt32(Console.ReadLine());

            bool packageSizeLimit = packageLengthInt > 50 ^ packageHeightInt > 50 ^ packageWidthInt > 50;
            int packageQuote = packageLengthInt * packageHeightInt * packageWidthInt / 100;
            if (weightLimit == true)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
            }
            else if (packageSizeLimit == true)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day!");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote + "\n Have a good day!");
            }
            Console.Read();

        }
    }
}
