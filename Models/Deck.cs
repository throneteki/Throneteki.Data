namespace CrimsonDev.Throneteki.Data.Models
{
    using System;
    using System.Collections.ObjectModel;
    using CrimsonDev.Gameteki.Data.Models;
    using CrimsonDev.Throneteki.Data.GameData;

    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }
        public string OwnerId { get; set; }
        public int? FactionId { get; set; }
        public int? AgendaId { get; set; }

        public virtual Collection<DeckCard> DeckCards { get; set; }
        public virtual GametekiUser Owner { get; set; }
        public virtual Faction Faction { get; set; }
        public virtual Card Agenda { get; set; }
    }
}