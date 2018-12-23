namespace CrimsonDev.Throneteki.Data.GameData
{
    using System;
    using System.Collections.Generic;

    public class Pack
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
    }
}