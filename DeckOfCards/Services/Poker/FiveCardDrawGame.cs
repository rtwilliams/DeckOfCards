using DeckOfCards.Business.Models;

namespace DeckOfCards.Services.Poker
{
    public class FiveCardDrawGame : CardGame
    {
        /// <summary>
        /// The game Five Card Draw uses a Poker/Standard deck. 
        /// </summary>
        public FiveCardDrawGame() : base("Five Card Draw", 5, new StandardDeck())
        {
        }
    }
}
