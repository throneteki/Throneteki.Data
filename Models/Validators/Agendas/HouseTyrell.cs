namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01205", Faction = "House Tyrell")]
    public class HouseTyrell : BannerValidator
    {
        public HouseTyrell(string factionName)
            : base(factionName)
        {
        }
    }
}
