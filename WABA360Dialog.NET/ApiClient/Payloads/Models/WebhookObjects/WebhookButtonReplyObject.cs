﻿using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class WebhookButtonReplyObject
    {
        /// <summary>
        /// Id of replying to Quick Reply Message
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Title of replying to Quick Reply Message
        /// </summary>
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
