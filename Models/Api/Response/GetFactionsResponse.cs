namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.Collections.Generic;
    using CrimsonDev.Gameteki.Data.Models.Api;
    using CrimsonDev.Throneteki.Data.GameData;

    public class GetFactionsResponse : ApiResponse
    {
        public List<Faction> Factions { get; set; }
    }
}