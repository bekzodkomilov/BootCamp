using System.Text.Json.Serialization;

namespace lesson10.Dto.User
{
    public class Result
    {
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("login")]
        public Login Login { get; set; }

        [JsonPropertyName("dob")]
        public Dob Dob { get; set; }

        [JsonPropertyName("registered")]
        public Registered Registered { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("cell")]
        public string Cell { get; set; }

        [JsonPropertyName("id")]
        public Id Id { get; set; }

        [JsonPropertyName("picture")]
        public Picture Picture { get; set; }

        [JsonPropertyName("nat")]
        public string Nat { get; set; }
    }
}