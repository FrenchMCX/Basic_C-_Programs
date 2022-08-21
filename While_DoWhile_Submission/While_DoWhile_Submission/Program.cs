using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_DoWhile_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 17;
            do
            {
                switch (number)
                {
                    case 17:
                        Console.WriteLine("You guessed correct!");
                        isGuessed = true;
                        Console.Read();
                        break;
                    case 18:
                        Console.WriteLine("You're close. Try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("You're close. Try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You're wrong. Try again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            while (number > 30)
            {
                switch (number)
                {
                    case -17:
                        Console.WriteLine("Right number, opposite value!");
                        break;
                    default :
                        Console.WriteLine("You're way off! Think lower!");
                        break;
                }
            }
        }
    }
}
