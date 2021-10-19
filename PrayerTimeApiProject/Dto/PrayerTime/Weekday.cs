using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Weekday
    {
        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("ar")]
        public string Ar { get; set; }
    }
}