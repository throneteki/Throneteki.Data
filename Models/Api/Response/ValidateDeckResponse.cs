namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using CrimsonDev.Gameteki.Data.Models.Api;
    using CrimsonDev.Throneteki.Data.Models.Validators;

    public class ValidateDeckResponse : ApiResponse
    {
        public DeckValidationResult Result { get; set; }
    }
}
