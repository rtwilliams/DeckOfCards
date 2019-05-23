using DeckOfCards.Data;

namespace DeckOfCards.Business.Models
{
    public class UnoDeck : Deck
    {
        public UnoDeck() : base("Uno", CardsDataLayer.GetUnoCards())
        {
        }
        
        public void ResetDeck()
        {
            base.ResetDeck(CardsDataLayer.GetUnoCards());
        }
    }
}
