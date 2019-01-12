namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    using CrimsonDev.Throneteki.Data.GameData;

    [AgendaValidator(Code = "00004")]
    public class UnitingTheSevenKingdoms : DraftAgenda
    {
        public override bool MayInclude(Card card)
        {
            return card.IsDrawCard();
        }
    }
}
