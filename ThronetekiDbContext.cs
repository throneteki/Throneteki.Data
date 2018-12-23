namespace CrimsonDev.Throneteki.Data
{
    using CrimsonDev.Gameteki.Data;
    using CrimsonDev.Throneteki.Data.GameData;
    using CrimsonDev.Throneteki.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ThronetekiDbContext : GametekiDbContext, IThronetekiDbContext
    {
        public ThronetekiDbContext()
        {
        }

        public ThronetekiDbContext(DbContextOptions<ThronetekiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Faction> Faction { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Pack> Pack { get; set; }
        public DbSet<RestrictedListEntry> RestrictedListEntry { get; set; }
        public DbSet<Deck> Deck { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RestrictedListEntry>(restrictedList =>
            {
                restrictedList.HasKey(r => r.Id);

                restrictedList.HasMany(rl => rl.JoustCards).WithOne(jc => jc.RestrictedListEntry).HasForeignKey(el => el.RestrictedListEntryId);
                restrictedList.HasMany(rl => rl.MeleeCards).WithOne(mc => mc.RestrictedListEntry).HasForeignKey(rl => rl.RestrictedListEntryId);
            });

            builder.Entity<RestrictedListMeleeCard>(mc =>
            {
                mc.HasKey(c => new { c.RestrictedListEntryId, c.CardId });
            });
            builder.Entity<RestrictedListJoustCard>(jc =>
            {
                jc.HasKey(c => new { c.RestrictedListEntryId, c.CardId });
            });

            builder.Entity<Deck>(deck =>
            {
                deck.HasMany(d => d.DeckCards).WithOne(dc => dc.Deck).HasForeignKey(dc => dc.DeckId);
            });

            builder.Entity<DeckCard>(dc =>
            {
                dc.HasKey(c => new { c.DeckId, c.CardId });
            });

            builder.Entity<Card>().OwnsOne(card => card.Icons);
            builder.Entity<Card>().OwnsOne(card => card.PlotStats);
            builder.Entity<Card>().HasIndex(card => card.Code).IsUnique();
            builder.Entity<Pack>().HasIndex(pack => pack.Code).IsUnique();
            builder.Entity<Faction>().HasIndex(faction => faction.Code).IsUnique();
        }
    }
}
