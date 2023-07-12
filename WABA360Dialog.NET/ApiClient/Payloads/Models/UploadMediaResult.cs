using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models
{
    public class UploadMediaResult
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
