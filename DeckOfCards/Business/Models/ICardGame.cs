using Business.Models.DeckOfCards;
using System.Collections.Generic;

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
