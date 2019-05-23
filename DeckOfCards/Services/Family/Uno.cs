using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using DeckOfCards.Data;
using System.Collections.Generic;

namespace DeckOfCards.Services.Family
{
    public class Uno : CardGame
    {
        public Uno(IDeck deck) :base(deck)
        {
        }

        public override List<CardModel> Deal()
        {
            return Deck.GetCards().GetRange(0, 11);
        }

        public override void ResetDeck()
        {
            base.Deck.ResetDeck(CardsDataLayer.GetUnoCards());
        }
    }
}
