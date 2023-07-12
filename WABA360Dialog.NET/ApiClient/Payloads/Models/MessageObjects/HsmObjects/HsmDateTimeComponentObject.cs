using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.HsmObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class HsmDateTimeComponentObject
    {
        /// <summary>
        /// Optional.
        /// If different from the value derived from the date (if specified), use the derived value. Both strings and numbers are accepted.
        /// Options: "MONDAY", 1, "TUESDAY", 2, "WEDNESDAY", 3, "THURSDAY", 4, "FRIDAY", 5, "SATURDAY", 6, "SUNDAY", 7
        /// </summary>
        [JsonProperty("day_of_week")]
        [JsonPropertyName("day_of_week")]
        public int? DayOfWeek { get; set; }

        /// <summary>
        /// Optional.
        /// The year
        /// </summary>
        [JsonProperty("year")]
        [JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// Optional.
        /// The month.
        /// </summary>
        [JsonProperty("month")]
        [JsonPropertyName("month")]
        public int? Month { get; set; }

        /// <summary>
        /// Optional.
        /// The day of month.
        /// </summary>
        [JsonProperty("day_of_month")]
        [JsonPropertyName("day_of_month")]
        public int? DayOfMonth { get; set; }

        /// <summary>
        /// Optional.
        /// The hour.
        /// </summary>
        [JsonProperty("hour")]
        [JsonPropertyName("hour")]
        public int? Hour { get; set; }

        /// <summary>
        /// Optional.
        /// The minute.
        /// </summary>
        [JsonProperty("minute")]
        [JsonPropertyName("minute")]
        public int? Minute { get; set; }

        /// <summary>
        /// Optional.
        /// Type of calendar.
        /// Options: GREGORIAN, SOLAR_HIJRI
        /// </summary>
        [JsonProperty("calendar")]
        [JsonPropertyName("calendar")]
        public string Calendar { get; set; }
    }
}
