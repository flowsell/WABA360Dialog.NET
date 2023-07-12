using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.InteractiveObjects
{
    public class TextFooterObject
    {
        /// <summary>
        /// Required if the footer object is present.
        /// The footer content. Emojis and markdown are supported. Links are supported.
        /// Maximum length: 60 characters
        /// </summary>
        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
