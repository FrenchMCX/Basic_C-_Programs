using System;
using System.Collections.Generic;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize methods
            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();

            //Instantiate
            employee1.Things = new List<string>()
            {
                "Words", "MoreWords", "Example", "Things"
            };

            employee2.Things = new List<int>()
            {
                1, 2, 3, 4, 5
            };

            //Loop and print
            for (int i = 0; i < employee1.Things.Count; i++)
            {
                Console.WriteLine(employee1.Things[i]);
            }

            for (int i = 0; i < employee2.Things.Count; i++)
            {
                Console.WriteLine(employee2.Things[i]);
            }

        }
    }
}
