namespace CrimsonDev.Throneteki.Data.GameData
{
    using Newtonsoft.Json;

    public class Faction
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Code { get; set; }
        public string Name { get; set; }
    }
}