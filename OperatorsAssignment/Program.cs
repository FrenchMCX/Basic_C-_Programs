﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.ID = 1;
            employee2.ID = 2;
            Console.WriteLine(employee1==employee2);
            Console.WriteLine(employee1 != employee2);

            Console.ReadLine();

        }
    }
}
