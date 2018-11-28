using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return Deck.Cards.GetRange(0, 5);
        }

        public CardModel Draw()
        {
            return Deck.Cards[0];
        }

        public string GetDeckName()
        {
            return Deck.Name;
        }

        public void ShuffleDeck()
        {
            Deck.Shuffle();
        }

        public void ResetDeck()
        {
            Deck.ResetDeck();
        }
    }
}
