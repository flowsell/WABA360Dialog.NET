using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models
{
    public class SendMessageContactResult
    {
        [JsonProperty("input")]
        [JsonPropertyName("input")]
        public string Input { get; set; }

        [JsonProperty("wa_id")]
        [JsonPropertyName("wa_id")]
        public string WaId { get; set; }
    }
}
