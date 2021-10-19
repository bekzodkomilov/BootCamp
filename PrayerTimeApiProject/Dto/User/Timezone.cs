using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Timezone
    {
        [JsonPropertyName("offset")]
        public string Offset { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}