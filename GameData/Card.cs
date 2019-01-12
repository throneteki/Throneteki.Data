namespace CrimsonDev.Throneteki.Data.GameData
{
    using System.Collections.Generic;
    using CrimsonDev.Throneteki.Data.Constants;

    public class Card
    {
        private static readonly List<string> DrawCardTypes = new List<string>
        {
            CardType.Attachment,
            CardType.Character,
            CardType.Event,
            CardType.Location
        };

        public int Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public int DeckLimit { get; set; }
        public string Cost { get; set; }
        public virtual PlotStats PlotStats { get; set; }
        public string Strength { get; set; }
        public string Traits { get; set; }
        public bool Unique { get; set; }
        public bool Loyal { get; set; }
        public virtual CardIcons Icons { get; set; }
        public string Label { get; set; }
        public int FactionId { get; set; }
        public int PackId { get; set; }

        public virtual Pack Pack { get; set; }
        public virtual Faction Faction { get; set; }

        public bool IsDrawCard()
        {
            return DrawCardTypes.Contains(Type);
        }

        public bool IsPlotCard()
        {
            return Type == CardType.Plot;
        }

        public bool HasTrait(string trait)
        {
            return Traits.ToLower().Contains(trait.ToLower());
        }

        public bool IsCharacter()
        {
            return Type == CardType.Character;
        }

        public bool IsDraftCard()
        {
            return Pack.Code == "VDS";
        }
    }
}
