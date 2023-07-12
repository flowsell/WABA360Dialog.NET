using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class NameObject
    {
        /// <summary>
        /// Required.
        /// Full name, as it normally appears.
        /// </summary>
        [JsonProperty("formatted_name")]
        [JsonPropertyName("formatted_name")]
        public string FormattedName { get; set; }

        /// <summary>
        /// Optional*.
        /// First name
        /// </summary>
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional*.
        /// Last name.
        /// </summary>
        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional*.
        /// Middle name.
        /// </summary>
        [JsonProperty("middle_name")]
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Optional*.
        /// Name suffix.
        /// </summary>
        [JsonProperty("suffix")]
        [JsonPropertyName("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// Optional*.
        /// Name prefix.
        /// </summary>
        [JsonProperty("prefix")]
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }
    }
}
