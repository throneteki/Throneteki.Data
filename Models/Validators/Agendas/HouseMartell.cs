namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01201", Faction = "House Martell")]
    public class HouseMartell : BannerValidator
    {
        public HouseMartell(string factionName)
            : base(factionName)
        {
        }
    }
}
