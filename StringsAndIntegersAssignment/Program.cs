using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create list
            List<int> integers = new List<int>();
            integers.Add(40);
            integers.Add(32);
            integers.Add(24);
            integers.Add(12);

            //create try and catch
            try
            {
                //loop through each integer in the list and print them
                for (int i = 0; i < integers.Count; i++)
                {
                    Console.WriteLine(integers[i]);
                }

                Console.WriteLine(" ");
                //Ask for and receive input, convert input string to int
                Console.WriteLine("Pick a number to divide each value in the list by.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                for (int i = 0; i < integers.Count; i++)
                {
                    //convert integers string to int, divide int by input
                    Console.WriteLine(integers[i] / numberOne);
                }

            }
            //catch exception if incorrect format is input
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            //catch exception if 0 is input
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            //catch general exception
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Allow user to see the final result/message
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
