using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.InteractiveObjects
{
    public class ButtonObject
    {
        /// <summary>
        /// Required.
        /// only supported type is reply (for Reply Button Messages)
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public ButtonType Type { get; set; }

        [JsonProperty("reply")]
        [JsonPropertyName("reply")]
        public ReplyObject Reply { get; set; }
    }
}
