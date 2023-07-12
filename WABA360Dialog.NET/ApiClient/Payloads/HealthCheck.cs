using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WABA360Dialog.ApiClient.Payloads.Base;

namespace WABA360Dialog.ApiClient.Payloads
{
    public class HealthCheckRequest : ClientApiRequestBase<HealthCheckResponse>
    {
        public HealthCheckRequest() : base("v1/health", HttpMethod.Get)
        {
        }
    }

    public class HealthCheckResponse : ClientApiResponseBase
    {
        [JsonProperty("health")]
        [JsonPropertyName("health")]
        public JObject Health { get; set; }
    }
}
