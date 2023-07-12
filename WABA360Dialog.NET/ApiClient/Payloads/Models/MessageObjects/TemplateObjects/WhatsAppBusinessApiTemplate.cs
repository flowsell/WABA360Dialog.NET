using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.Common.Enums;
using WABA360Dialog.PartnerClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.TemplateObjects
{
    public class WhatsAppBusinessApiTemplate
    {
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        [JsonPropertyName("status")]
        public TemplateStatus Status { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public WhatsAppLanguage Language { get; set; }

        [JsonProperty("category")]
        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonProperty("components")]
        [JsonPropertyName("components")]
        public IEnumerable<TemplateComponentObject> Components { get; set; }

        [JsonProperty("rejected_reason")]
        [JsonPropertyName("rejected_reason")]
        public string RejectedReason { get; set; }

        [JsonProperty("namespace")]
        [JsonPropertyName("namespace")]
        public string Namespace { get; set; }
    }
}
