using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Deck deck = new Deck();
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() {"Tyler", "Jesse", "Oscar"};
            game.ListPlayers();
            game.Play();
            Console.ReadLine();

            deck.Shuffle(3);

            foreach (Card card in deck.Cards) 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

       

    }
}
