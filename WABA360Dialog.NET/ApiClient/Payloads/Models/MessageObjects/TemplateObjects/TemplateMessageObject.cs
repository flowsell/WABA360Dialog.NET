using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;
using WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.InteractiveObjects;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.TemplateObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TemplateMessageObject
    {
        /// <summary>
        /// Required.
        /// Namespace of the template.
        /// </summary>
        [JsonProperty("namespace")]
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// Required.
        /// Name of the template.
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required.
        /// Contains a language object. Specifies the language the template may be rendered in.
        /// Only the deterministic language policy works with media template messages.
        /// </summary>
        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public LanguageObject Language { get; set; }

        /// <summary>
        /// Optional.
        /// Array of components objects containing the parameters of the message.
        /// </summary>
        [JsonProperty("components")]
        [JsonPropertyName("components")]
        public IEnumerable<TemplateMessageComponentObject> Components { get; set; }
    }
}
