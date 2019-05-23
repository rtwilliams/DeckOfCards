using Business.Models.DeckOfCards;
using System.Collections.Generic;

namespace DeckOfCards.Business.Models
{
    public interface IDeck
    {
        string GetName();
        List<CardModel> GetCards();
        void Shuffle();
        void ResetDeck(List<CardModel> cards);
    }
}
