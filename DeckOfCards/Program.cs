using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using DeckOfCards.Services.Family;
using DeckOfCards.Services.Poker;
using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        const string returnMessage = "Press any key to go back to the menu.";

        static void Main(string[] args)
        {
            ConsoleKey input = ConsoleKey.A;
            do
            {
                input = DisplayMainMenu().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        GameMenu(new FiveCardDraw(new StandardDeck()));
                        break;
                    case ConsoleKey.D2:
                        GameMenu(new Uno(new UnoDeck()));
                        break;
                }
            }
            while (!input.Equals(ConsoleKey.Q));
            Environment.Exit(0);
        }

        private static ConsoleKeyInfo DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Play a game. Choose an option:\n");
            Console.WriteLine("1.) Five Card Draw");
            Console.WriteLine("2.) Uno");
            Console.WriteLine("q.) Quit\n");
            var key = Console.ReadKey();
            return key;
        }

        private static ConsoleKeyInfo DisplayGameMenu(string deckName)
        {
            Console.Clear();
            Console.WriteLine("This game uses a " + deckName + " deck of cards. Choose an option:\n");
            Console.WriteLine("s.) Shuffle Deck");
            Console.WriteLine("d.) Deal Hand");
            Console.WriteLine("x.) Draw Card");
            Console.WriteLine("r.) Reset Deck");
            Console.WriteLine("q.) Quit\n");
            var key = Console.ReadKey();
            return key;
        }

        private static void GameMenu(ICardGame game)
        {
            ConsoleKey input;
            do
            {
                Console.Clear();
                input = DisplayGameMenu(game.GetDeckName()).Key;
                switch (input)
                {
                    case ConsoleKey.D:
                        DisplayHand(game.Deal());
                        break;
                    case ConsoleKey.X:
                        DisplayCard(game.Draw());
                        break;
                    case ConsoleKey.S:
                        Shuffle(game);
                        break;
                    case ConsoleKey.R:
                        Reset(game);
                        break;
                }
            }
            while (!input.Equals(ConsoleKey.Q));
        }

        private static ConsoleKey DisplayHand(List<CardModel> hand)
        {
            Console.WriteLine("\n\nPrint all cards in hand: \n");
            foreach (var card in hand)
            {
                Console.WriteLine(String.Format("{0}", card.Print()));
            }
            Console.WriteLine("\nPress any key to continue...");
            return MenuReturn();
        }

        private static ConsoleKey DisplayCard(CardModel card)
        {
            Console.WriteLine(string.Format("\n\nCard drawn: {0}", card.Print()));
            Console.WriteLine("\nPress any key to continue...");
            return MenuReturn();
        }

        private static ConsoleKey Shuffle(ICardGame game)
        {
            game.ShuffleDeck();
            Console.WriteLine("\n\nDeck Shuffled\n");
            Console.WriteLine("Press any key to continue...");
            return MenuReturn();
        }

        private static ConsoleKey Reset(ICardGame game)
        {
            game.ResetDeck();
            Console.WriteLine("\n\nDeck Reset\n");
            Console.WriteLine("Press any key to continue...");
            return MenuReturn();
        }

        private static ConsoleKey MenuReturn()
        {
            Console.ReadKey();
            Console.WriteLine("\n" + returnMessage);
            Console.WriteLine("Press any key to continue...");
            return ConsoleKey.Q;
        }
    }
}
