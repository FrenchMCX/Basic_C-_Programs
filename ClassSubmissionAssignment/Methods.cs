using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Methods
    {
        //Method that divides input by 2
        public void divideTwo(int input1) 
        {
            int result = input1 / 2;
            Console.WriteLine(result);
        }
        //Overloaded method
        public void divideTwo(int input1, int input2) 
        { 
            int result = input1 * input2 / 2; 
            Console.WriteLine(result); 
        }

        //method with output parameters
        public void Result(out string i) 
        {
            i = "Thanks for using the program!";
        }
    }
}
