using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Person
    {
        //Declare properties
        string firstName { get; set; }
        string lastName { get; set; }

        //Create SayName method
        public virtual void SayName(string firstName, string lastName)
        {
            Console.WriteLine("My name is: " + firstName + " " + lastName);
        }
    }
}
