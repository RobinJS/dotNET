using System;

class PlayingCards
{
    static void Main()
    {
        Console.WriteLine("This program prints out the full set of 52 playing cards. To continue, press any key...");
        Console.ReadLine();

        string cards = "";
        string suits = "";

        for (int i = 1; i <= 13; i++)
        {
            switch (i)
            {
                case 1: cards = "Ace"; break;
                case 2: cards = "Two"; break;
                case 3: cards = "Three"; break;
                case 4: cards = "Four"; break;
                case 5: cards = "Five"; break;
                case 6: cards = "Six"; break;
                case 7: cards = "Seven"; break;
                case 8: cards = "Eight"; break;
                case 9: cards = "Nine"; break;
                case 10: cards = "Ten"; break;
                case 11: cards = "Jack"; break;
                case 12: cards = "Queen"; break;
                case 13: cards = "King"; break;
                default: Console.WriteLine("Error!"); break;
            }

            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1: suits = "Spades"; break;
                    case 2: suits = "Hearts"; break;
                    case 3: suits = "Diamonds"; break;
                    case 4: suits = "Clubs"; break;
                    default: Console.WriteLine("Error!"); break;
                }
                string result = cards + " of " + suits;
                Console.Write("{0, -19}", result);
            }

            Console.WriteLine();
        }
    }
}
