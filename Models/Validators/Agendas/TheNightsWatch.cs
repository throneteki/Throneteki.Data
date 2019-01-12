namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01202", Faction = "The Night's Watch")]
    public class TheNightsWatch : BannerValidator
    {
        public TheNightsWatch(string factionName)
            : base(factionName)
        {
        }
    }
}
