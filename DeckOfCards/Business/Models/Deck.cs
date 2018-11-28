using Business.Models.DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Business.Models
{
    public class Deck : IDeck
    {
        public string Name { get; set; }
        public List<CardModel> Cards { get; set; }
        public Deck()
        {
            Cards = new List<CardModel>();
        }

        public void Shuffle()
        {
            var rand = new Random();
            var mIndex = Cards.Count;
            int nIndex;
            while (mIndex > 1)
            {
                mIndex--;
                nIndex = rand.Next(mIndex + 1);
                var card = Cards[nIndex];
                Cards[nIndex] = Cards[mIndex];
                Cards[mIndex] = card;
            }
        }

        public virtual void ResetDeck()
        {
            throw new NotImplementedException();
        }
    }
}
