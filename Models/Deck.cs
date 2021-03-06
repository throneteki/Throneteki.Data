﻿namespace CrimsonDev.Throneteki.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CrimsonDev.Gameteki.Data.Models;
    using CrimsonDev.Throneteki.Data.Constants;
    using CrimsonDev.Throneteki.Data.GameData;

    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public string OwnerId { get; set; }
        public int? FactionId { get; set; }

        public virtual Collection<DeckCard> DeckCards { get; set; }
        public virtual GametekiUser Owner { get; set; }
        public virtual Faction Faction { get; set; }

        [NotMapped]
        public Card Agenda
        {
            get
            {
                var allianceAgenda = DeckCards.SingleOrDefault(dc => dc.CardType == DeckCardType.Normal && dc.Card.Code == "06018");

                return allianceAgenda != null ? allianceAgenda.Card : DeckCards.SingleOrDefault(dc => dc.CardType == DeckCardType.Normal && (dc.Card.Code == "06018" || dc.Card.Type == CardType.Agenda))?.Card;
            }
        }

        public List<DeckCard> GetNormalCards()
        {
            return DeckCards.Where(dc => dc.CardType == DeckCardType.Normal).ToList();
        }

        public List<DeckCard> GetRookeryCards()
        {
            return DeckCards.Where(dc => dc.CardType == DeckCardType.Rookery).ToList();
        }
    }
}