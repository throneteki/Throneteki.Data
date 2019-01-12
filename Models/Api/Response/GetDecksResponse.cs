namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.Collections.Generic;
    using CrimsonDev.Gameteki.Data.Models.Api;

    public class GetDecksResponse : ApiResponse
    {
        public List<ApiDeck> Decks { get; set; }
    }
}
