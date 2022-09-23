using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate methods
            Methods methods = new Methods();

            //Ask for and receive inputs. Note to use zero if they desire to enter no number for second input.
            Console.WriteLine("Insert up to 2 numbers to add with 7. (If you wish to only use 1 number please enter zero for the second.)");
            int input1 = Convert.ToInt32(Console.ReadLine());

            string input2 = Console.ReadLine();
            if (input2 == "")
            {
                int result = methods.addSeven(input1);
                Console.WriteLine(result);
            }
            else 
            {
                int result1 = methods.addSeven(input1, Convert.ToInt32(input2));
                Console.WriteLine(result1);
            }

            

            Console.ReadLine();
        }
    }
}
