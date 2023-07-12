using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Base;

namespace WABA360Dialog.ApiClient.Payloads
{
    public class UpdateProfileInfoAboutTextRequest : ClientApiRequestBase<UpdateProfileInfoAboutTextResponse>
    {
        public UpdateProfileInfoAboutTextRequest(string aboutText) : base("v1/settings/profile/about", new HttpMethod("PATCH"))
        {
            AboutText = aboutText;

        }

        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string AboutText { get; }
    }

    public class UpdateProfileInfoAboutTextResponse : ClientApiResponseBase
    {
    }
}
