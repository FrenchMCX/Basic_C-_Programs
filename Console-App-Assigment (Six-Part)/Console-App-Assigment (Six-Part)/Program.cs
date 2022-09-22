using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assigment__Six_Part_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            String[] favoriteArtistsArray = new String[4];
            favoriteArtistsArray[0] = "Eden";
            favoriteArtistsArray[1] = "The Gaslight Anthem";
            favoriteArtistsArray[2] = "Nothing But Thieves";
            favoriteArtistsArray[3] = "Coldplay";

            for (int i = 0; i < 4; i++)
            {
            Console.WriteLine(favoriteArtistsArray[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Enter your opinion of these artists in one word:");
            string opinion = Console.ReadLine();
            Console.WriteLine("You said: " + opinion);
            Console.WriteLine(" ");

            for (int i = 0; i < 4; i++)
            {
                favoriteArtistsArray[i] = favoriteArtistsArray[i] + opinion;
            }

            for (int i = 0; i < 4; i++)
            { 
            Console.WriteLine(favoriteArtistsArray[i]);
            }

            Console.ReadLine();
            //Part 1

            //Part 2
            int count = 0;

        //Fixed loop by adding count "< 4 rather" than "true"
           while (count < 4)
            {
                Console.WriteLine("Count = {0}.", count);
                count++;
            }
            Console.ReadLine();
            //Part 2

            //Part 3
            int countTwo = 0;
            while (countTwo < 5)
            {
                Console.WriteLine("Count = {0}", countTwo);
                countTwo++;
            }
            Console.ReadLine();

            int countThree = 0;
            while (countThree <= 5)
            {
                Console.WriteLine("Count = {0}", countThree);
                countThree++;
            }
            Console.ReadLine();
            //Part 3

            //Part 4
            List<string> rockBandInstruments = new List<string>();
            rockBandInstruments.Add("vocals");
            rockBandInstruments.Add("guitar");
            rockBandInstruments.Add("bass");
            rockBandInstruments.Add("drums");

            Console.WriteLine("Insert a rock band instrument (in all lowercase) to search for in the list: ");
            string response = Console.ReadLine();

            bool found = false;

            foreach (string instrument in rockBandInstruments)
            {
                if (response == instrument)
                {
                    Console.WriteLine("Can be found at index: " + rockBandInstruments.IndexOf(instrument));
                    found = true;
                    break;
                }
            }
            if (!found)
            { 
                Console.WriteLine("Instrument not found in the list.");
            }

            Console.ReadLine();
            //Part 4

            //Part 5
            List<string> animals = new List<string>();
            animals.Add("pig");
            animals.Add("cow");
            animals.Add("dog");
            animals.Add("pig");
            animals.Add("cat");
            animals.Add("wolf");

            Console.WriteLine("Insert an animal (in all lowercase) to search for in the list: ");
            string input = Console.ReadLine();

            found = false;

            for (int i = 0; i < animals.Count; i++)
            {
                if (input == animals[i])
                {
                    Console.WriteLine("Can be found at index: " + i);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Animal not found in the list.");
            }
            Console.ReadLine();
            //Part 5

            //Part 6

            //create lists
            List<string> uniqueOne = new List<string>();
            uniqueOne.Add("A");
            uniqueOne.Add("B");
            uniqueOne.Add("C");
            uniqueOne.Add("D");
            uniqueOne.Add("A");

            List<string> uniqueTwo = new List<string>();

            //declare unique or duplicate string
            string unique = "unique";
            string duplicate = "a duplicate";
            foreach (string one in uniqueOne)
            {
                //Check to see if we've seen list item before
                if (uniqueTwo.Contains(one))
                {
                    Console.WriteLine(one + " - this item is " + duplicate);
                }
                else 
                {
                    //Haven't seen list item before
                    uniqueTwo.Add(one);
                    Console.WriteLine(one + " - this item is " + unique);
                }

            }

            Console.ReadLine();
            //Part 6

        }
    }
}
