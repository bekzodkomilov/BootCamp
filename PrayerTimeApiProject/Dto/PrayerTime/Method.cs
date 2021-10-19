using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Method
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("params")]
        public Params Params { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
    }
}