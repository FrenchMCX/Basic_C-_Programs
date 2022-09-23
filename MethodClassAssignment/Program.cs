using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate methods
            Methods methods = new Methods();
            int input1 = 1;
            int input2 = 2;

            //Call method
            methods.addSeven(1, 2);
            methods.addSeven(input1, input2);

            Console.ReadLine();
        }
    }
}
