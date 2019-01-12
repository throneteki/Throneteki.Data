namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    using CrimsonDev.Throneteki.Data.GameData;

    [AgendaValidator(Code = "11079")]
    public class TheFreeFolk : BaseValidator
    {
        public override bool CannotInclude(Card card)
        {
            return card.Faction.Code != "neutral";
        }
    }
}
