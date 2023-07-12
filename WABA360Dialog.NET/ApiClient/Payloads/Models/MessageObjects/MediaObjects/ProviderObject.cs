using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.MediaObjects
{
    /// <summary>
    /// Media Providers
    /// https://developers.facebook.com/docs/whatsapp/api/settings/media-providers
    /// </summary>
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ProviderObject
    {
        /// <summary>
        /// Required.
        /// The name for the provider
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required.
        /// The type of provider
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required.
        /// The ConfigObject
        /// </summary>
        [JsonProperty("config")]
        [JsonPropertyName("config")]
        public ConfigObject Config { get; set; }
    }

}
