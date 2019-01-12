namespace CrimsonDev.Throneteki.Data.Models.Validators
{
    using System;

    public class AgendaValidatorAttribute : Attribute
    {
        public string Code { get; set; }
        public string Faction { get; set; }
    }
}