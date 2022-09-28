using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeesList = new List<Employee>()
            {
                new Employee()
                {ID = 1,
                fName = "Joe",
                lName = "Doe"},

                new Employee()
                {ID = 2,
                fName = "Joe",
                lName = "Deer" },

                new Employee()
                {ID = 3,
                fName = "John",
                lName = "Deer" },

                new Employee()
                {ID = 4,
                fName = "John",
                lName = "Doe" },

                new Employee()
                {ID = 5,
                fName = "Bob",
                lName = "Deer" },

                new Employee()
                {ID = 6,
                fName = "Bob",
                lName = "Dee" },

                new Employee()
                {ID = 7,
                fName = "Bob",
                lName = "Doe" },

                new Employee()
                {ID = 8,
                fName = "John",
                lName = "Antler" },

                new Employee()
                {ID = 9,
                fName = "John",
                lName = "Paw" },

                new Employee()
                {ID = 10,
                fName = "John",
                lName = "Deerington" },
            };

            List<Employee> Joes = new List<Employee>();

            foreach (Employee employeeExample in EmployeesList)
            {
                if (employeeExample.fName == "Joe")
                {
                    Joes.Add(employeeExample);
                }
            }

            List<Employee> Joes2 = EmployeesList.Where(x => x.fName == "Joe").ToList();


            List<Employee> greaterThanFive = EmployeesList.Where(x => x.ID > 5).ToList();
        
    }
    }
}
