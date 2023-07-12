using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class EmailObject
    {
        /// <summary>
        /// Optional.
        /// Email address
        /// </summary>
        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional.
        /// Standard Values: HOME, WORK
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public PlaceType? Type { get; set; }
    }
}
