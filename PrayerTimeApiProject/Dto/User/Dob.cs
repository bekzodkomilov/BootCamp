using System;
using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Dob
    {
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }
}