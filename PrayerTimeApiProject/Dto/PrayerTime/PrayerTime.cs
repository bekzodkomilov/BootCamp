using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class PrayerTime
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}