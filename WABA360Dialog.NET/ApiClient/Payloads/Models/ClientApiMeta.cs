using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models
{
    public class ClientApiMeta
    {
        [JsonProperty("api_status")]
        [JsonPropertyName("api_status")]
        public string ApiStatus { get; set; }

        [JsonProperty("version")]
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonProperty("success")]
        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonProperty("http_code")]
        [JsonPropertyName("http_code")]
        public int? HttpCode { get; set; }

        [JsonProperty("developer_message")]
        [JsonPropertyName("developer_message")]
        public string DeveloperMessage { get; set; }
    }
}
