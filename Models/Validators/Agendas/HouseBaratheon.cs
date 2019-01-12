namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01198", Faction="House Baratheon")]
    public class HouseBaratheon : BannerValidator
    {
        public HouseBaratheon(string factionName)
            : base(factionName)
        {
        }
    }
}
