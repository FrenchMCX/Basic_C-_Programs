using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Methods
    {
        //method to add 7 to input
        public int addSeven(int input) { int result = input + 7; return result; }
        //method to add 7.7 to input
        public double addSeven(double input) { double result = input + 7.7; return (int)result; }
        //method to add 7 to input
        public string addSeven(string input) { string result = input + 7; return result; }
    }
}
