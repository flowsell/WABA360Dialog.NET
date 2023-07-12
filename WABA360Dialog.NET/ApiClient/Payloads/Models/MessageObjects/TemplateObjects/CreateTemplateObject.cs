using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;
using WABA360Dialog.Common.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.TemplateObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class CreateTemplateObject
    {
        /// <summary>
        /// Required.
        /// The type of message template.
        /// </summary>
        [JsonProperty("category")]
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// Required.
        /// The name of the message template.
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required.
        /// The language of the message template
        /// </summary>
        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public WhatsAppLanguage Language { get; set; }

        /// <summary>
        /// Optional.
        /// Array of components objects containing the parameters of the message.
        /// </summary>
        [JsonProperty("components")]
        [JsonPropertyName("components")]
        public IEnumerable<TemplateComponentObject> Components { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TemplateComponentObject
    {
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public TemplateComponentType Type { get; set; }

        [JsonProperty("format")]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonProperty("example")]
        [JsonPropertyName("example")]
        public object Example { get; set; }

        [JsonProperty("buttons")]
        [JsonPropertyName("buttons")]
        public IEnumerable<TemplateButtonObject> Buttons { get; set; }
    }

    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TemplateButtonObject
    {
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public TemplateButtonType Type { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonProperty("example")]
        [JsonPropertyName("example")]
        public object Example { get; set; }

        [JsonProperty("phone_number")]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("otp_type")]
        [JsonPropertyName("otp_type")]
        public string OtpType { get; set; }

        [JsonProperty("autofill_text")]
        [JsonPropertyName("autofill_text")]
        public string AutofillText { get; set; }

        [JsonProperty("package_name")]
        [JsonPropertyName("package_name")]
        public string PackageName { get; set; }

        [JsonProperty("signature_hash")]
        [JsonPropertyName("signature_hash")]
        public string SignatureHash { get; set; }
    }
}
