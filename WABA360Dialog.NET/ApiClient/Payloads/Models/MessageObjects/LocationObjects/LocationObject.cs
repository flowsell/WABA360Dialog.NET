using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.LocationObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class LocationObject
    {
        /// <summary>
        /// Required.
        /// Longitude of the location.
        /// </summary>
        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Required.
        /// Latitude of the location.
        /// </summary>
        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Optional.
        /// Name of the location.
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional.
        /// Address of the location. Only displayed if name is present.
        /// </summary>
        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}
