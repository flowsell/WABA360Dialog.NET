using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;
using WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.HsmObjects;
using WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.MediaObjects;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class ParameterObject
    {
        /// <summary>
        /// Required.
        /// Describes the parameter type.
        /// Values: text, currency, date_time, image, document, video & payload
        /// The media types (image, document and video) follow the same format as those used in standard media messages, see the Media documentation for more information. Only PDF documents are currently supported for media message templates.
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public ParameterType Type { get; set; }

        /// <summary>
        /// Required when type is set to text.
        /// The text message parameter.
        /// </summary>
        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Required when type is set to payload for quick_reply buttons.
        /// Developer-defined payload that will be returned when the button is clicked in addition to the display text on the button.
        /// </summary>
        [JsonProperty("payload")]
        [JsonPropertyName("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// Required when type is set to image.
        /// The media object containing image.
        /// </summary>
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public MediaObject Image { get; set; }

        /// <summary>
        /// Required when type is set to audio.
        /// The media object containing audio.
        /// </summary>
        [JsonProperty("audio")]
        [JsonPropertyName("audio")]
        public MediaObject Audio { get; set; }

        /// <summary>
        /// Required when type is set to document.
        /// The media object containing a document.
        /// </summary>
        [JsonProperty("document")]
        [JsonPropertyName("document")]
        public MediaObject Document { get; set; }

        /// <summary>
        /// Required when type is set to video.
        /// The media object containing a video.
        /// </summary>
        [JsonProperty("video")]
        [JsonPropertyName("video")]
        public MediaObject Video { get; set; }

        /// <summary>
        /// Required when type is set to currency.
        /// The currency parameter.
        /// </summary>
        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public CurrencyObject Currency { get; set; }

        /// <summary>
        /// Required when type is set to date_time.
        /// The date time parameter.
        /// </summary>
        [JsonProperty("date_time")]
        [JsonPropertyName("date_time")]
        public DateTimeObject DateTime { get; set; }
    }

}
