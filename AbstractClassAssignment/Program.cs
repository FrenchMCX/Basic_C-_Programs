using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate method
            Employee employee = new Employee();

            //call method, pass in names
            employee.SayName("Sample", "Student");

            Console.ReadLine();
        }
    }
}
