using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.Common
{
    public class ErrorObject
    {
        /// <summary>
        /// Error code.
        /// </summary>
        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public int Code { get; set; }

        /// <summary>
        /// Error title.
        /// </summary>
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Optional. Error details provided, if available/applicable.
        /// </summary>
        [JsonProperty("details")]
        [JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// Optional. Location for error detail.
        /// </summary>
        [JsonProperty("href")]
        [JsonPropertyName("href")]
        public string Href { get; set; }
    }
}
