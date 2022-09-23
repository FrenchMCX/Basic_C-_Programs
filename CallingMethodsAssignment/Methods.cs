using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    internal class Methods
    {
        //Method that adds 7 to the input
        public int addSeven(int input) 
        {
            int result = input + 7;
            return result;
        }
        //Method that subtracts 7 from the input
        public int subtractSeven(int input) 
        {
            int result = input - 7;
            return result;
        }
        //Method that multiplies the input by 7
        public int multiplySeven(int input)
        {
            int result = input * 7;
            return result;
        }
    }
}
