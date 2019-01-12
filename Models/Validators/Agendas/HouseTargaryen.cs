namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "01204", Faction = "House Targaryen")]
    public class HouseTargaryen : BannerValidator
    {
        public HouseTargaryen(string factionName)
            : base(factionName)
        {
        }
    }
}
