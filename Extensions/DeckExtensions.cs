namespace CrimsonDev.Throneteki.Data.Extensions
{
    using System;
    using System.Linq;
    using CrimsonDev.Throneteki.Data.GameData;
    using CrimsonDev.Throneteki.Data.Models;

    public static class DeckExtensions
    {
        public static int CountCards(this Deck deck, DeckCardType cardType, Func<Card, bool> filterFunction)
        {
            return deck.DeckCards.Sum(dc => dc.CardType == cardType && filterFunction(dc.Card) ? dc.Count : 0);
        }
    }
}
