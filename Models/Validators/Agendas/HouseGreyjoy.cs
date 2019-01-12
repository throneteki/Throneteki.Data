namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01199", Faction = "House Greyjoy")]
    public class HouseGreyjoy : BannerValidator
    {
        public HouseGreyjoy(string factionName)
            : base(factionName)
        {
        }
    }
}
