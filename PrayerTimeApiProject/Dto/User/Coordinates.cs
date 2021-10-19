using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Coordinates
    {
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }
}