using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create integer array
            int[] numArray = new int[5];
            //define integers
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            //create string array
            string[] stringArray = new string[5];
            //define strings
            stringArray[0] = "String 1";
            stringArray[1] = "String 2";
            stringArray[2] = "String 3";
            stringArray[3] = "String 4";
            stringArray[4] = "String 5";

            Console.WriteLine("Insert a number 0 through 4: ");
            int input = int.Parse(Console.ReadLine());
            //if statement to limit correct inputs to 4
            if (input > 4)
            {
                Console.WriteLine("Invalid Choice!");
            }
            else
            {
                Console.WriteLine("You picked array number: " + numArray[input]);
            }


            Console.WriteLine("Insert a number 0 through 4: ");
            int inputString = Convert.ToInt32(Console.ReadLine());
            //if statement to limit correct inputs to 4
            if (inputString > 4)
            {
                Console.WriteLine("Invalid Choice!");
            }
            else
            {
                Console.WriteLine("You picked : " + stringArray[inputString]);
            }

            //define list
            List<string> instrumentList = new List<string>();
            instrumentList.Add("Guitar");
            instrumentList.Add("Bass");
            instrumentList.Add("Drums");
            instrumentList.Add("Harmonica");
            instrumentList.Add("Cello");

            Console.WriteLine("Insert a number 0 through 4: ");
            //convert list ReadLine string into int
            int inputList = Convert.ToInt32(Console.ReadLine());
            //if statement to limit correct inputs to 4
            if (inputList > 4)
            {
                Console.WriteLine("Invalid Choice!");
            }
            else
            {
                Console.WriteLine("You picked : " + instrumentList[inputList]);
            }

            Console.Read();
        }
    }
}
