using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Params
    {
        [JsonPropertyName("Fajr")]
        public double Fajr { get; set; }

        [JsonPropertyName("Isha")]
        public string Isha { get; set; }
    }
}