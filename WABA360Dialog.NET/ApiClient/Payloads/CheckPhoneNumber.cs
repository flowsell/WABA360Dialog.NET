using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Base;

namespace WABA360Dialog.ApiClient.Payloads
{
    public class CheckPhoneNumberRequest : ClientApiRequestBase<CheckPhoneNumberResponse>
    {
        public CheckPhoneNumberRequest() : base("v1/configs/phone_number", HttpMethod.Get)
        {
        }
    }

    public class CheckPhoneNumberResponse : ClientApiResponseBase
    {
        [JsonProperty("phone_number")]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
