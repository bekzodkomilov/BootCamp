using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Street
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}