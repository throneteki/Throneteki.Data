namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.Collections.Generic;
    using CrimsonDev.Gameteki.Data.Models.Api;
    using CrimsonDev.Throneteki.Data.GameData;

    public class GetPacksResponse : ApiResponse
    {
        public List<Pack> Packs { get; set; }
    }
}