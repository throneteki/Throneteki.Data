namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.Collections.Generic;
    using CrimsonDev.Gameteki.Data.Models.Api;

    public class GetCardsResponse : ApiResponse
    {
        public Dictionary<string, ApiCard> Cards { get; set; }
    }
}