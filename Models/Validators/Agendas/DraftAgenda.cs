namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    public abstract class DraftAgenda : BaseValidator
    {
        public override int? RequiredDraw => 40;
        public override int? RequiredPlots => 5;
    }
}
