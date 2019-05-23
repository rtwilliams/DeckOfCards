using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using DeckOfCards.Data;
using System.Collections.Generic;

namespace DeckOfCards.Services
{
    public class CardGame : ICardGame
    {
        public string Name { get; set; }
        public IDeck Deck { get; set; }

        public CardGame(IDeck deck)
        {
            Deck = deck;
        }

        public virtual List<CardModel> Deal()
        {
            return Deck.GetCards().GetRange(0, 5);
        }

        public CardModel Draw()
        {
            return Deck.GetCards()[0];
        }

        public string GetDeckName()
        {
            return Deck.GetName();
        }

        public void ShuffleDeck()
        {
            Deck.Shuffle();
        }

        public virtual void ResetDeck()
        {
            Deck.ResetDeck(CardsDataLayer.GetStandardDeck());
        }
    }
}
