using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_Approval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print title
            Console.WriteLine("Insurance Approval Questionnaire \n");
            //Declare variables
            string age;
            int ageInt;
            //Ask for input
            Console.WriteLine("What is your age? \n");
            age = Console.ReadLine();
            //Convert string to int
            ageInt = Convert.ToInt32(age);
            //Declare variables and declare true as true
            string dui;
            bool duiBool = true != true;
            //Ask for input
            Console.WriteLine("Have you ever had a DUI? Please enter true or false: \n");
            dui = Console.ReadLine();
            //Convert string to boolean
            duiBool = Convert.ToBoolean(dui);
            //Declare variables
            string tickets;
            int ticketsInt;
            Console.WriteLine("Have you gotten any speeding tickets? If so, how many? \n");
            tickets = Console.ReadLine();
            //Convert string to int
            ticketsInt = Convert.ToInt32(tickets);
            //Declare variable hasDui and evaluate if true or false
            bool hasDui = duiBool == false;
            //Declare variable qualify and make sure it meets all requirements to qualify
            bool qualify = ageInt >= 15 && hasDui && ticketsInt <= 3;
            Console.WriteLine("Qualified? \n" + qualify);


            Console.Read();
        }
    }
}
