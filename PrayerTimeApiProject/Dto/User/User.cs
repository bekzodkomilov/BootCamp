using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{

    public class User
    {
        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }

        [JsonPropertyName("info")]
        public Info Info { get; set; }
    }
}