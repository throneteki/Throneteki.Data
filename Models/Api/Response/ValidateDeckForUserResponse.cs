namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using CrimsonDev.Gameteki.Data.Models.Api;
    using CrimsonDev.Throneteki.Data.Models.Validators;

    public class ValidateDeckForUserResponse : ApiResponse
    {
        public DeckValidationResultShort Result { get; set; }
    }
}
