using Business.Models.DeckOfCards;
using DeckOfCards.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Services.Poker
{
    public class FiveCardDraw : CardGame
    {
        public FiveCardDraw(IDeck deck) : base(deck)
        {
            Name = "Five Card Draw";
        }
    }
}
