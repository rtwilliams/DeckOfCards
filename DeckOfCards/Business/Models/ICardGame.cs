using Business.Models.DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Business.Models
{
    public interface ICardGame
    {
        string GetDeckName();
        void ShuffleDeck();
        List<CardModel> Deal();
        CardModel Draw();
        void ResetDeck();
    }
}
