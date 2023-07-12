using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class WebhookSystemObject
    {
        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonProperty("new_wa_id")]
        [JsonPropertyName("new_wa_id")]
        public string NewWaId { get; set; }

        [JsonProperty("identity")]
        [JsonPropertyName("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

    }
}
