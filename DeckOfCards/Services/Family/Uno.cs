using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Services.Family
{
    public class Uno : CardGame
    {
        public Uno(IDeck deck) :base(deck)
        {
            Name = "Uno";
        }

        public override List<CardModel> Deal()
        {
            return Deck.Cards.GetRange(0, 11);
        }
    }
}
