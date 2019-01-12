namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01200", Faction = "House Lannister")]
    public class HouseLannister : BannerValidator
    {
        public HouseLannister(string factionName)
            : base(factionName)
        {
        }
    }
}
