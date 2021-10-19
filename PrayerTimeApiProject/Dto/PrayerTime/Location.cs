using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Location
    {
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }
    }
}