namespace CrimsonDev.Throneteki.Data.GameData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Newtonsoft.Json;

    public class Card
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int DeckLimit { get; set; }
        public string Cost { get; set; }
        public virtual PlotStats PlotStats { get; set; }
        public string Strength { get; set; }
        [JsonIgnore]
        public string Traits { get; set; }
        public bool Unique { get; set; }
        public bool Loyal { get; set; }
        public virtual CardIcons Icons { get; set; }
        public string Label { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "faction")]
        public string FactionCode => Faction.Code;

        [NotMapped]
        public string PackCode => Pack.Code;

        [JsonIgnore]
        public int FactionId { get; set; }
        [JsonIgnore]
        public int PackId { get; set; }

        [JsonIgnore]
        public virtual Pack Pack { get; set; }
        [JsonIgnore]
        public virtual Faction Faction { get; set; }

        [NotMapped]
        [JsonProperty(PropertyName = "traits")]
        public List<string> TraitList => Traits.Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();
    }
}
