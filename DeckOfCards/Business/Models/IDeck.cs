using Business.Models.DeckOfCards;
using System.Collections.Generic;

namespace DeckOfCards.Business.Models
{
    public interface IDeck
    {
        /// <summary>
        /// Returns name of deck.
        /// </summary>
        string GetName();

        /// <summary>
        /// Returns list of cards in deck.
        /// </summary>
        List<CardModel> GetCards();

        /// <summary>
        /// Shuffles deck.
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Resets the deck. Cards will be ordered by suite and number.
        /// </summary>
        /// <param name="cards"></param>
        void ResetDeck(List<CardModel> cards);
    }
}
