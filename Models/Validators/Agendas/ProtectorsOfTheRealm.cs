namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    using CrimsonDev.Throneteki.Data.GameData;

    [AgendaValidator(Code = "00002")]
    public class ProtectorsOfTheRealm : DraftAgenda
    {
        public override bool MayInclude(Card card)
        {
            return card.IsCharacter() && (card.HasTrait("Knight") || card.HasTrait("Army"));
        }
    }
}
