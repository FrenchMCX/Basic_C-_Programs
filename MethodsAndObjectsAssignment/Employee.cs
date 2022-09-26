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

        //Constructor for Employee with inherited variables
        public Employee(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }
    }
}
