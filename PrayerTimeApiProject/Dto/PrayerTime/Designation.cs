using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Designation
    {
        [JsonPropertyName("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonPropertyName("expanded")]
        public string Expanded { get; set; }
    }
}