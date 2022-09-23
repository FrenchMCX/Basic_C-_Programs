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
        public int addSeven(double input) { int result = Convert.ToInt32(input + 7.7); return result; }
        //method to add 7 to input
        public int addSeven(string input) { int result = Convert.ToInt32(input) + 7; return result; }
    }
}
