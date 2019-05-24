using Business.Models.DeckOfCards;
using System.Collections.Generic;

namespace DeckOfCards.Business.Models
{
    public interface ICardGame
    {
        /// <summary>
        /// Returns name of game.
        /// </summary>
        string GetName();

        /// <summary>
        /// Returns name of deck.
        /// </summary>
        string GetDeckName();

        /// <summary>
        /// Shuffles deck.
        /// </summary>
        void ShuffleDeck();

        /// <summary>
        /// Deals out a hand.
        /// </summary>
        List<CardModel> Deal();

        /// <summary>
        /// Draws one card of the top of the deck.
        /// </summary>
        CardModel Draw();

        /// <summary>
        /// Resets deck. Cards will be ordered by suite and number.
        /// </summary>
        void ResetDeck();
    }
}
