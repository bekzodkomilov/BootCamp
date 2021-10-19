using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Date
    {
        [JsonPropertyName("readable")]
        public string Readable { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        [JsonPropertyName("hijri")]
        public Hijri Hijri { get; set; }

        [JsonPropertyName("gregorian")]
        public Gregorian Gregorian { get; set; }
    }
}