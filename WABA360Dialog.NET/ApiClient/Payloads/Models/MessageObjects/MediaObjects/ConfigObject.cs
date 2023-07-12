using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.MediaObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ConfigObject
    {
        [JsonProperty("basic")]
        [JsonPropertyName("basic")]
        public BasicAuth Basic { get; set; }

        [JsonProperty("bearer")]
        [JsonPropertyName("bearer")]
        public BearerAuth Bearer { get; set; }

        public class BasicAuth
        {
            [JsonProperty("username")]
            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonProperty("password")]
            [JsonPropertyName("password")]
            public string Password { get; set; }
        }

        public class BearerAuth
        {
            [JsonProperty("bearer")]
            [JsonPropertyName("bearer")]
            public string Bearer { get; set; }
        }
    }
}
