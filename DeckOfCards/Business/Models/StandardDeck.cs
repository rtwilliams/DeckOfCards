using Business.Models.DeckOfCards;
using DeckOfCards.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Business.Models
{
    public class StandardDeck : Deck
    {
        public StandardDeck()
        {
            Name = "Standard";
            Cards = DeckDataLayer.GetStandardDeck();
        }

        public override void ResetDeck()
        {
            Cards = DeckDataLayer.GetStandardDeck();
        }
    }
}
