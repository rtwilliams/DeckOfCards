using DeckOfCards.Business.Models;
using DeckOfCards.Data;

namespace DeckOfCards.Services.Poker
{
    public class FiveCardDraw : CardGame
    {
        public FiveCardDraw(IDeck deck) : base(deck)
        {
        }
    }
}
