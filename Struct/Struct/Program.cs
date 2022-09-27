using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intantiate Number
            Number number = new Number();
            //Set Value
            number.x = 35;
            //Print
            Console.WriteLine(number.x);
            Console.ReadLine();
        }

        //Create Struct
        struct Number
        {
            public int x;
        }
    }
}
