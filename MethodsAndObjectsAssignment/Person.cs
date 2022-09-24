using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Person
    {
        //Declare variables
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Create constructor for Person
        public Person() 
        {
            firstName = "Sample";
            lastName = "Student";
        }

        //Method for stating person's name
        public void SayName() 
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
