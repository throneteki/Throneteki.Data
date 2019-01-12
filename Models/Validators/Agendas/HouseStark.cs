namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01203", Faction = "House Stark")]
    public class HouseStark : BannerValidator
    {
        public HouseStark(string factionName)
            : base(factionName)
        {
        }
    }
}
