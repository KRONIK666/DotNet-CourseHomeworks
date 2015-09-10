using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> cards = new Dictionary<int, string>();
            Dictionary<int, string> hand = new Dictionary<int, string>();

            cards.Add(1, "Spades 2"); cards.Add(2, "Spades 3"); cards.Add(3, "Spades 4"); cards.Add(4, "Spades 5"); cards.Add(5, "Spades 6");
            cards.Add(6, "Spades 7"); cards.Add(7, "Spades 8"); cards.Add(8, "Spades 9"); cards.Add(9, "Spades 10"); cards.Add(10, "Spades J");
            cards.Add(11, "Spades Q"); cards.Add(12, "Spades K"); cards.Add(13, "Spades A"); cards.Add(14, "Hearts 2"); cards.Add(15, "Hearts 3");
            cards.Add(16, "Hearts 4"); cards.Add(17, "Hearts 5"); cards.Add(18, "Hearts 6"); cards.Add(19, "Hearts 7"); cards.Add(20, "Hearts 8");
            cards.Add(21, "Hearts 9"); cards.Add(22, "Hearts 10"); cards.Add(23, "Hearts J"); cards.Add(24, "Hearts Q"); cards.Add(25, "Hearts K");
            cards.Add(26, "Hearts A"); cards.Add(27, "Diamonds 2"); cards.Add(28, "Diamonds 3"); cards.Add(29, "Diamonds 4"); cards.Add(30, "Diamonds 5");
            cards.Add(31, "Diamonds 6"); cards.Add(32, "Diamonds 7"); cards.Add(33, "Diamonds 8"); cards.Add(34, "Diamonds 9"); cards.Add(35, "Diamonds 10");
            cards.Add(36, "Diamonds J"); cards.Add(37, "Diamonds Q"); cards.Add(38, "Diamonds K"); cards.Add(39, "Diamonds A"); cards.Add(40, "Clubs 2");
            cards.Add(41, "Clubs 3"); cards.Add(42, "Clubs 4"); cards.Add(43, "Clubs 5"); cards.Add(44, "Clubs 6"); cards.Add(45, "Clubs 7");
            cards.Add(46, "Clubs 8"); cards.Add(47, "Clubs 9"); cards.Add(48, "Clubs 10"); cards.Add(49, "Clubs J"); cards.Add(50, "Clubs Q");
            cards.Add(51, "Clubs K"); cards.Add(52, "Clubs A");

            Console.WriteLine("Pick a number between 1 and 52 to draw a card!");
            Console.WriteLine();

            int[] temp = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Draw a card: ");
                int number = int.Parse(Console.ReadLine());

                if (number > 0 & number < 53)
                {
                    temp[i] = number;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Don't cheat! Draw a card between 1 and 52!");
                    Console.WriteLine();
                    i--;
                }
            }

            for (int i = 0; i < temp.Length; i++)
            {
                foreach (var item in cards)
                {
                    if (temp[i] == item.Key)
                    {
                        hand.Add(item.Key, item.Value);
                    }
                }
            }

            int n = 0;
            string[] winningCards = new string[5];

            foreach (string card in hand.Values)
            {
                winningCards[n] = card;
                winningCards[n] = winningCards[n].Substring(winningCards[n].Length - 1);
                n += 1;
            }

            int currentPair = 0;
            int highestPair = 0;

            for (int i = 0; i < winningCards.Length; i++)
            {
                int pair = 1;

                for (int j = 0; j < winningCards.Length; j++)
                {
                    if (winningCards[i] == winningCards[j] && i != j)
                    {
                        pair += 1;
                    }
                } currentPair = pair;

                if (currentPair > highestPair)
                {
                    highestPair = currentPair;
                }
            }

            if (highestPair == 2)
            {
                Console.WriteLine();
                Console.WriteLine("You have at least One Pair!");
            }
            else if (highestPair == 3)
            {
                Console.WriteLine();
                Console.WriteLine("You have Three Of A Kind!");
            }
            else if (highestPair == 4)
            {
                Console.WriteLine();
                Console.WriteLine("You have Four Of A Kind!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your hand is:");
                Console.WriteLine();

                foreach (string card in hand.Values)
                {
                    Console.WriteLine(card);
                }
            } Console.WriteLine();
        }
    }
}