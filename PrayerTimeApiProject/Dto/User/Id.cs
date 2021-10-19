using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Id
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}