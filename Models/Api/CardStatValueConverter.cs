namespace CrimsonDev.Throneteki.Data.Models.Api
{
    using System;
    using Newtonsoft.Json;

    public class CardStatValueConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var stringValue = value.ToString();
            if (stringValue == "X" || stringValue == "-")
            {
                writer.WriteValue(value);

                return;
            }

            if (!int.TryParse(stringValue, out var intValue))
            {
                throw new ArgumentException($"{value} is not a valid value for this field");
            }

            writer.WriteValue(intValue);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}