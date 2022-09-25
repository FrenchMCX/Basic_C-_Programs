using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate method
            Employee employee = new Employee();

            //Call method
            employee.Quit();

            Console.ReadLine();
        }
    }
}
