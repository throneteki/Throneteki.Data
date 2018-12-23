namespace CrimsonDev.Throneteki.Data.GameData
{
    using System;
    using System.Collections.Generic;

    public class RestrictedListEntry
    {
        public RestrictedListEntry()
        {
            MeleeCards = new List<RestrictedListMeleeCard>();
            JoustCards = new List<RestrictedListJoustCard>();
        }

        public int Id { get; set; }
        public string Version { get; set; }
        public DateTime Date { get; set; }

        public ICollection<RestrictedListMeleeCard> MeleeCards { get; set; }
        public ICollection<RestrictedListJoustCard> JoustCards { get; set; }
    }
}
