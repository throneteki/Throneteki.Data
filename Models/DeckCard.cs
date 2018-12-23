namespace CrimsonDev.Throneteki.Data.Models
{
    using CrimsonDev.Throneteki.Data.GameData;

    public class DeckCard
    {
        public int DeckId { get; set; }
        public int CardId { get; set; }
        public DeckCardType CardType { get; set; }
        public int Count { get; set; }

        public virtual Deck Deck { get; set; }
        public virtual Card Card { get; set; }
    }
}
