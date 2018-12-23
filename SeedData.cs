namespace CrimsonDev.Throneteki.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CrimsonDev.Throneteki.Data.GameData;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ThronetekiDbContext>();

            await CheckAndAddFactions(context);
        }

        private static async Task CheckAndAddFactions(ThronetekiDbContext context)
        {
            var factions = new List<Faction>
            {
                new Faction { Code = "baratheon", Name = "House Baratheon" },
                new Faction { Code = "thenightswatch", Name = "The Night's Watch" },
                new Faction { Code = "greyjoy", Name = "House Greyjoy" },
                new Faction { Code = "tyrell", Name = "House Tyrell" },
                new Faction { Code = "martell", Name = "House Martell" },
                new Faction { Code = "stark", Name = "House Stark" },
                new Faction { Code = "lannister", Name = "House Lannister" },
                new Faction { Code = "targaryen", Name = "House Targaryen" },
                new Faction { Code = "neutral", Name = "Neutral" }
            };

            var factionsByCode = factions.ToDictionary(key => key.Code, value => value);
            var factionCodes = factions.Select(f => f.Code);
            var dbFactionCodes = await context.Faction.Select(f => f.Code).ToListAsync();

            var missingFactions = factionCodes.Except(dbFactionCodes);

            foreach (var faction in missingFactions)
            {
                context.Faction.Add(factionsByCode[faction]);
            }

            await context.SaveChangesAsync();
        }
    }
}
