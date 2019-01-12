namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using CrimsonDev.Gameteki.Data.Models.Api;

    public class GetDeckResponse : ApiResponse
    {
        public ApiDeck Deck { get; set; }
    }
}
