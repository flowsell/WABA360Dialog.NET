﻿using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Base;

namespace WABA360Dialog.ApiClient.Payloads
{
    public class GetWebhookUrlRequest : ClientApiRequestBase<GetWebhookUrlResponse>
    {
        public GetWebhookUrlRequest() : base("v1/configs/webhook", HttpMethod.Get)
        {
        }
    }

    public class GetWebhookUrlResponse : ClientApiResponseBase
    {
        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("headers")]
        [JsonPropertyName("headers")]
        public Dictionary<string, string> Headers { get; set; }
    }
}
