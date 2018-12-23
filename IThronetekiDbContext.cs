namespace CrimsonDev.Throneteki.Data
{
    using CrimsonDev.Gameteki.Data;
    using CrimsonDev.Throneteki.Data.GameData;
    using CrimsonDev.Throneteki.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public interface IThronetekiDbContext : IGametekiDbContext
    {
        DbSet<Faction> Faction { get; set; }
        DbSet<Card> Card { get; set; }
        DbSet<Pack> Pack { get; set; }
        DbSet<Deck> Deck { get; set; }
        DbSet<RestrictedListEntry> RestrictedListEntry { get; set; }
    }
}