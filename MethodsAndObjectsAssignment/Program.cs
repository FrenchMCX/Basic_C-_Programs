using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate employee method
            Employee employee = new Employee("Sample", "Student");

            //Call method
            employee.SayName();

            Console.ReadLine();

        }
    }
}
