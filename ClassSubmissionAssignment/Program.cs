using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate methods
            Methods methods = new Methods();
            Methods result = new Methods();
            

            //Declare variables
            string i; 
            int input1 = Convert.ToInt32(Console.ReadLine());

            //Call methods
            methods.divideTwo(input1);
            methods.Result(out i);
            StaticClass.divideThree(3);

            //Print results
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
