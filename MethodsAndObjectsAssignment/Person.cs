﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Person
    {
        //Declare properties
        public string firstName { get; set; }
        public string lastName { get; set; }


        //Method for stating person's name
        public void SayName() 
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}
