using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class AddressObject
    {
        /// <summary>
        /// Optional.
        /// Street number and name
        /// </summary>
        [JsonProperty("street")]
        [JsonPropertyName("street")]
        public string Street { get; set; }

        /// <summary>
        /// Optional.
        /// City name.
        /// </summary>
        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Optional.
        /// State abbreviation.
        /// </summary>
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Optional.
        /// ZIP code.
        /// </summary>
        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Optional.
        /// Full country name.
        /// </summary>
        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Optional.
        /// Two-letter country abbreviation.
        /// </summary>
        [JsonProperty("country_code")]
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Optional.
        /// Standard Values: HOME, WORK
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public PlaceType? Type { get; set; }
    }
}
