﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;

namespace WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.InteractiveObjects
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class TemplateMessageComponentObject
    {
        /// <summary>
        /// Required.
        /// Describes the component type.
        /// Values: header, body, or button. For text-based templates, we only support the type=body.
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public ComponentType Type { get; set; }

        /// <summary>
        /// Optional. Used when type is set to button.
        /// Supported values are:
        /// quick_reply: Refers to a previously created quick reply button that allows for the customer to return a predefined message. See Callback from a Quick Reply Button Click for an example of a response from a quick reply button.
        /// url: Refers to a previously created button that allows the customer to visit the URL generated by appending the text parameter to the predefined prefix URL in the template.
        /// </summary>
        [JsonProperty("sub_type")]
        [JsonPropertyName("sub_type")]
        public ButtonType? SubType { get; set; }

        /// <summary>
        /// Optional. Used when type is set to button.
        /// Position index of the button. You can have up to 3 buttons using index values of 0-2.
        /// </summary>
        [JsonProperty("index")]
        [JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Optional.
        /// Array of parameter objects with the content of the message.
        /// </summary>
        [JsonProperty("parameters")]
        [JsonPropertyName("parameters")]
        public IEnumerable<ParameterObject> Parameters { get; set; }

        /// <summary>
        /// Optional.
        /// Set to true if you want the template to include the string, For your security, do not share this code. Set to false to exclude the string.
        /// </summary>
        [JsonProperty("add_security_recommendation")]
        [JsonPropertyName("add_security_recommendation")]
        public bool? AddSecurityRecommendation { get; set; }

        /// <summary>
        /// Optional.
        /// Indicates number of minutes the password or code is valid.
        /// If omitted, the code expiration warning will not be displayed in the delivered message.
        /// Minimum 1, maximum 90.
        /// </summary>
        [JsonProperty("code_expiration_minutes")]
        [JsonPropertyName("code_expiration_minutes")]
        public int? CodeExpirationMinutes { get; set; }
    }
}
