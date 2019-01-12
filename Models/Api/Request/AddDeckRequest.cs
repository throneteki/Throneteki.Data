namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System.ComponentModel.DataAnnotations;

    public class AddDeckRequest
    {
        [Required]
        public ApiDeck Deck { get; set; }
    }
}
