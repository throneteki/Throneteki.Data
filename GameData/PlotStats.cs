namespace CrimsonDev.Throneteki.Data.GameData
{
    using CrimsonDev.Throneteki.Data.Models.Api;
    using Newtonsoft.Json;

    public class PlotStats
    {
        [JsonConverter(typeof(CardStatValueConverter))]
        public string Income { get; set; }
        [JsonConverter(typeof(CardStatValueConverter))]
        public string Initiative { get; set; }
        [JsonConverter(typeof(CardStatValueConverter))]
        public string Claim { get; set; }
        [JsonConverter(typeof(CardStatValueConverter))]
        public string Reserve { get; set; }
    }
}