using DeckOfCards.Business.Models;
using DeckOfCards.Data;

namespace DeckOfCards.Services.Family
{
    public class UnoGame : CardGame
    {
        /// <summary>
        /// The game Uno uses an Uno deck
        /// </summary>
        public UnoGame() :base("Uno", 11, new UnoDeck())
        {
        }

        public override void ShuffleDeck()
        {
            ResetDeck();
            Deck.Shuffle();
        }

        public override void ResetDeck()
        {
            base.Deck.ResetDeck(CardsDataLayer.GetUnoCards());
        }
    }
}
