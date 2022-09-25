using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Employee : Person, IQuittable
        {
            //Override SayName method
            public override void SayName(string firstName, string lastName)
            {
                firstName = "Sample";
                lastName = "Student";
                Console.WriteLine("My name is: " + firstName + " " + lastName);
            }

        //Utilizing quit method
        public void Quit() 
        {
            Console.WriteLine("You are now Quitting...");
        }
            
        }
}
