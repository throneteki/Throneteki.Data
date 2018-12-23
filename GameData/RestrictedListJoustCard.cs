namespace CrimsonDev.Throneteki.Data.GameData
{
    public class RestrictedListJoustCard
    {
        public int CardId { get; set; }
        public int RestrictedListEntryId { get; set; }

        public virtual Card Card { get; set; }
        public virtual RestrictedListEntry RestrictedListEntry { get; set; }
    }
}