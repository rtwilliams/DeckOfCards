using Business.Models.DeckOfCards;
using DeckOfCards.Business.Enumerations;
using System;
using System.Collections.Generic;

namespace DeckOfCards.Data
{
    public static class CardsDataLayer
    {
        public static List<CardModel> GetUnoCards()
        {
            var cards = new List<CardModel>();
            var suiteMax = 14;
            var suiteValues = Enum.GetValues(typeof(UnoSuites));
            foreach(var suite in suiteValues)
            {
                for(var i = 0; i <= suiteMax; i++)
                {
                    var card = new CardModel { Value = i, Suite = suite.ToString() };
                    switch (i)
                    {
                        case 10:
                            card.Name = "Skip";
                            break;
                        case 11:
                            card.Name = "Draw Two";
                            break;
                        case 12:
                            card.Name = "Reverse";
                            break;
                        case 13:
                            card.Name = "Wild";
                            break;
                        case 14:
                            card.Name = "Wild Draw 4";
                            break;
                        default:
                            card.Name = i.ToString();
                            break;
                    }
                    cards.Add(card);
                }
            }
            return cards;
        }

        public static List<CardModel> GetStandardDeck()
        {
            var cards = new List<CardModel>();
            var suiteMax = 13;
            var suiteValues = Enum.GetValues(typeof(StandardSuites));
            foreach (var suite in suiteValues)
            {
                for (var i = 1; i <= suiteMax; i++)
                {
                    var card = new CardModel { Value = i, Suite = suite.ToString() };
                    switch (i)
                    {
                        case 1:
                            card.Name = "Ace";
                            break;
                        case 11:
                            card.Name = "Jack";
                            break;
                        case 12:
                            card.Name = "Queen";
                            break;
                        case 13:
                            card.Name = "King";
                            break;
                        default:
                            card.Name = i.ToString();
                            break;
                    }
                    cards.Add(card);
                }
            }
            return cards;
        }
    }
}
