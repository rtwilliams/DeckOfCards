using DeckOfCards.Data;

namespace DeckOfCards.Business.Models
{
    public class StandardDeck : Deck
    {
        public StandardDeck() : base("Standard", CardsDataLayer.GetStandardDeck())
        {
        }

        public void ResetDeck() 
        {
            base.ResetDeck(CardsDataLayer.GetStandardDeck());
        }
    }
}
