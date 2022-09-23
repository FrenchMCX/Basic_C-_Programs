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
            //Try and Catch used to prevent program from not working when nothing is entered for second input.
            try
            {
                //Instantiate methods
                Methods methods = new Methods();

                //Ask for and receive inputs. Note to use zero if they desire to enter no number for second input.
                Console.WriteLine("Insert up to 2 numbers to add with 7. (If you wish to only use 1 number please enter zero for the second.)");
                int input1 = Convert.ToInt32(Console.ReadLine());

                int input2 = Convert.ToInt32(Console.ReadLine());

                //Call methods
                int result = methods.addSeven(input1, input2);

                //Print results
                Console.WriteLine(result);
            }
            catch (FormatException ex) { Console.WriteLine(ex.Message); }
            

            Console.ReadLine();
        }
    }
}
