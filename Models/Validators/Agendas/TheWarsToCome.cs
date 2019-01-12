namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    [AgendaValidator(Code = "10045")]
    public class TheWarsToCome : BaseValidator
    {
        public override int? RequiredPlots => 10;
        public override int? MaxDoublePlots => 2;
    }
}
