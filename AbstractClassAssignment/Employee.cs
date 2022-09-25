using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //Inherit from Person class
    internal class Employee : Person
    {
        //Override SayName method
        public override void SayName(string firstName, string lastName) 
        {
            firstName = "Sample";
            lastName = "Student";
            Console.WriteLine("My name is: " + firstName + " " + lastName);
        }
    }
}
