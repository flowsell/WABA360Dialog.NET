using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models
{
    public class CheckContactResult
    {
        [JsonProperty("input")]
        [JsonPropertyName("input")]
        public string Input { get; set; }

        [JsonProperty("wa_id")]
        [JsonPropertyName("wa_id")]
        public string WaId { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public ContactStatus Status { get; set; }
    }
}
