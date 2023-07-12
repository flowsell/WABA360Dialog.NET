using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class UrlObject
    {
        /// <summary>
        /// Optional.
        /// URL.
        /// </summary>
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Optional.
        /// Standard Values: HOME, WORK
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public PlaceType? Type { get; set; }
    }
}
