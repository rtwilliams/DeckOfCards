using Business.Models.DeckOfCards;
using System;
using System.Collections.Generic;

namespace DeckOfCards.Business.Models
{
    public class Deck : IDeck
    {
        readonly string _name;
        List<CardModel> _cards;

        public Deck(string name, List<CardModel> cards)
        {
            _name = name;
            _cards = cards;
        }

        public string GetName()
        {
            return _name;
        }

        public List<CardModel> GetCards()
        {
            return _cards;
        }

        public void Shuffle()
        {
            var rand = new Random();
            var mIndex = GetCards().Count;
            int nIndex;
            while (mIndex > 1)
            {
                mIndex--;
                nIndex = rand.Next(mIndex + 1);
                var card = GetCards()[nIndex];
                GetCards()[nIndex] = GetCards()[mIndex];
                GetCards()[mIndex] = card;
            }
        }

        public virtual void ResetDeck(List<CardModel> cards)
        {
            _cards = cards;
        }
    }
}
