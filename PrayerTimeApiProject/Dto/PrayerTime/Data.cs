using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Data
    {
        [JsonPropertyName("timings")]
        public Timings Timings { get; set; }

        [JsonPropertyName("date")]
        public Date Date { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}