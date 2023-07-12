using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class WebhookLocationObject
    {
        /// <summary>
        /// Latitude of location being sent.
        /// </summary>
        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude of location being sent.
        /// </summary>
        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Address of the location.
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Address of the location.
        /// </summary>
        [JsonProperty("address")]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// URL for the website where the user downloaded the location information.
        /// </summary>
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
