using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace lesson10.Dto.PrayerTime
{
    public class Hijri
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("day")]
        public string Day { get; set; }

        [JsonPropertyName("weekday")]
        public Weekday Weekday { get; set; }

        [JsonPropertyName("month")]
        public Month Month { get; set; }

        [JsonPropertyName("year")]
        public string Year { get; set; }

        [JsonPropertyName("designation")]
        public Designation Designation { get; set; }

        [JsonPropertyName("holidays")]
        public List<object> Holidays { get; set; }
    }
}