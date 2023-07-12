using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Base;
using WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.TemplateObjects;

namespace WABA360Dialog.ApiClient.Payloads
{
    public class GetTemplateRequest : ClientApiRequestBase<GetTemplateResponse>
    {
        public GetTemplateRequest(int limit = 1000, int offset = 0, string sort = null) : base("v1/configs/templates", HttpMethod.Get)
        {
            Limit = limit;
            Offset = offset;
            Sort = sort;

            QueryParams = new Dictionary<string, string>
            {
                ["limit"] = limit.ToString(),
                ["offset"] = offset.ToString(),
                ["sort"] = sort
            };
        }

        [Newtonsoft.Json.JsonIgnore]
        public int Limit { get; }

        [Newtonsoft.Json.JsonIgnore]
        public int Offset { get; }

        [Newtonsoft.Json.JsonIgnore]
        public string Sort { get; }
    }

    public class GetTemplateResponse : ClientApiResponseBase
    {
        [JsonProperty("count")]
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonProperty("filters")]
        [JsonPropertyName("filters")]
        public object Filters { get; set; }

        [JsonProperty("sort")]
        [JsonPropertyName("sort")]
        public IEnumerable<string> Sort { get; set; }

        [JsonProperty("limit")]
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonProperty("total")]
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonProperty("waba_templates")]
        [JsonPropertyName("waba_templates")]
        public IEnumerable<WhatsAppBusinessApiTemplate> WhatsAppBusinessApiTemplates { get; set; }
    }

}
