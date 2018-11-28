using DeckOfCards.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Business.Models
{
    public class UnoDeck : Deck
    {
        public UnoDeck()
        {
            Name = "Uno";
            Cards = DeckDataLayer.GetUnoDeck();
        }
        
        public override void ResetDeck()
        {
            Cards = DeckDataLayer.GetUnoDeck();
        }
    }
}
