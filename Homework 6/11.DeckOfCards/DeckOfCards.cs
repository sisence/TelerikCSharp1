//11. Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
//The cards should be printed with their English names. Use nested for loops and switch-case.


using System;

class DeckOfCards
{
    static void Main()
    {
        string[] cards = new string[13] { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        string[] colors = new string[4] { "Clubs", "Diamonds", "Hearts", "Spades" };

        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine(colors[i]);
            Console.WriteLine("----------");

            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}",cards[j],colors[i]); 
            }
        }
    }
}

