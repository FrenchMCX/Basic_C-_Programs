using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    //Inherit from Person class
    internal class Employee : Person
    {
        //Declare properties
        int ID;
        string firstName;
        string lastName;

        //Constructor for Employee with inherited variables
        public Employee(string firstName, string lastName, int ID)
        {
            //Declare new variable
            ID = 001;
        }
    }
}
