﻿using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class MessageIdentityObject
    {
        /// <summary>
        /// State of acknowledgment for latest user_identity_changed system notification.
        /// </summary>
        [JsonProperty("acknowledged")]
        [JsonPropertyName("acknowledged")]
        public string Acknowledged { get; set; }

        /// <summary>
        /// Timestamp of when the WhatsApp Business API client detected the user potentially changed.
        /// </summary>
        [JsonProperty("created_timestamp")]
        [JsonPropertyName("created_timestamp")]
        public long CreatedTimestamp { get; set; }

        /// <summary>
        /// Identifier for the latest user_identity_changed system notification.
        /// </summary>
        [JsonProperty("hash")]
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }
}
