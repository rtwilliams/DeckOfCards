using Business.Models.DeckOfCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards.Business.Models
{
    public interface IDeck
    {
        string Name { get; set; }
        List<CardModel> Cards { get; set; }
        void Shuffle();
        void ResetDeck();
    }
}
