using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using DeckOfCards.Data;
using System.Collections.Generic;

namespace DeckOfCards.Services
{
    public class CardGame : ICardGame
    {
        public string Name { get; set; }
        public int HandSize { get; set; }
        public IDeck Deck { get; set; }

        public CardGame(string name, int handSize, IDeck deck)
        {
            Name = name;
            HandSize = handSize;
            Deck = deck;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDeckName()
        {
            return Deck.GetName();
        }

        public virtual List<CardModel> Deal()
        {
            if (Deck.GetCards().Count < HandSize)
                return null;

            var hand = Deck.GetCards().GetRange(0, HandSize);
            Deck.GetCards().RemoveRange(0, HandSize);
            return hand;
        }

        public CardModel Draw()
        {
            if (Deck.GetCards().Count == 0)
                return null;

            var card = Deck.GetCards()[0];
            Deck.GetCards().RemoveAt(0);
            return card;
        }

        public virtual void ShuffleDeck()
        {
            ResetDeck();
            Deck.Shuffle();
        }

        public virtual void ResetDeck()
        {
            // default is standard deck
            Deck.ResetDeck(CardsDataLayer.GetStandardDeck());
        }
    }
}
