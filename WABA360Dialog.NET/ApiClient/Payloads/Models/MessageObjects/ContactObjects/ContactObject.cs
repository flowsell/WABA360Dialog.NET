using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ContactObject
    {
        /// <summary>
        /// Optional.
        /// Full contact address(es) —see AddressObject.
        /// </summary>
        [JsonProperty("addresses")]
        [JsonPropertyName("addresses")]
        public IEnumerable<AddressObject> Addresses { get; set; }

        /// <summary>
        /// Optional.
        /// YYYY-MM-DD formatted string.
        /// </summary>
        [JsonProperty("birthday")]
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// Optional.
        /// Contact email address(es) —see EmailObject.
        /// </summary>
        [JsonProperty("emails")]
        [JsonPropertyName("emails")]
        public IEnumerable<EmailObject> Emails { get; set; }

        /// <summary>
        /// Required.
        /// Full contact name — see NameObject.
        /// </summary>
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public NameObject Name { get; set; }

        /// <summary>
        /// Optional.
        /// Contact organization information —see OrgObject.
        /// </summary>
        [JsonProperty("org")]
        [JsonPropertyName("org")]
        public OrgObject Org { get; set; }

        /// <summary>
        /// Messaging contact information
        /// </summary>
        [JsonProperty("ims")]
        [JsonPropertyName("ims")]
        public IEnumerable<ImsObject> Ims { get; set; }

        /// <summary>
        /// Optional.
        /// Optional.
        /// Contact phone number(s) —see PhoneObject.
        /// </summary>
        [JsonProperty("phones")]
        [JsonPropertyName("phones")]
        public IEnumerable<PhoneObject> Phones { get; set; }

        /// <summary>
        /// Optional.
        /// Contact URL(s) —see UrlObject.
        /// </summary>
        [JsonProperty("urls")]
        [JsonPropertyName("urls")]
        public IEnumerable<UrlObject> Urls { get; set; }
    }
}
