﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using WABA360Dialog.ApiClient.Payloads.Enums;
using WABA360Dialog.ApiClient.Payloads.Models.Common;
using WABA360Dialog.ApiClient.Payloads.Models.MessageObjects.ContactObjects;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class WebhookMessageObject
    {
        /// <summary>
        /// Optional.
        /// This object will only be included when someone replies to one of your messages.
        /// Contains information about the content of the original message, such as the ID of the sender and the ID of the message.
        /// See context object for more information.
        /// </summary>
        [JsonProperty("context")]
        [JsonPropertyName("context")]
        public WebhookContextObject Context { get; set; }

        /// <summary>
        /// WhatsApp ID of the sender.
        /// </summary>
        [JsonProperty("from")]
        [JsonPropertyName("from")]
        public string From { get; set; }

        /// <summary>
        /// Message ID.
        /// </summary>
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Optional.
        /// Contains information about the user identity used to decrypt the incoming message. See identity object.
        /// </summary>
        [JsonProperty("identity")]
        [JsonPropertyName("identity")]
        public MessageIdentityObject Identity { get; set; }

        /// <summary>
        /// Message received timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Message type.
        /// Supported values are: unknown, text, audio, video, contacts, document, image, location, sticker, voice, interactive, button, order, system, ephemeral
        /// </summary>
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public WebhookMessageType Type { get; set; }

        /// <summary>
        /// When the notification describes a text message, the text object provides the body of the text message.
        /// </summary>
        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public WebhookTextObject Text { get; set; }

        /// <summary>
        /// When a message with audio is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("audio")]
        [JsonPropertyName("audio")]
        public WebhookMediaObject Audio { get; set; }

        /// <summary>
        /// When a message with document is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("document")]
        [JsonPropertyName("document")]
        public WebhookMediaObject Document { get; set; }

        /// <summary>
        /// When a message with image is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("image")]
        [JsonPropertyName("image")]
        public WebhookMediaObject Image { get; set; }

        /// <summary>
        /// When a message with media video is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("video")]
        [JsonPropertyName("video")]
        public WebhookMediaObject Video { get; set; }

        /// <summary>
        /// When a message with media voice is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("voice")]
        [JsonPropertyName("voice")]
        public WebhookMediaObject Voice { get; set; }

        /// <summary>
        /// When a message with media sticker is received, the WhatsApp Business API client will download the media. Once the media is downloaded, a notification is sent to your Webhook. This message contains information that identifies the media object and enables you to find and download the object.
        /// </summary>
        [JsonProperty("sticker")]
        [JsonPropertyName("sticker")]
        public WebhookMediaObject Sticker { get; set; }

        /// <summary>
        /// When you receive a notification of a user's static location, the location object provides the details of the location.
        /// </summary>
        [JsonProperty("location")]
        [JsonPropertyName("location")]
        public WebhookLocationObject Location { get; set; }

        /// <summary>
        /// When you receive a notification of a user's contact information, the contacts object provides the contact information details.
        /// </summary>
        [JsonProperty("contacts")]
        [JsonPropertyName("contacts")]
        public IEnumerable<ContactObject> Contacts { get; set; }

        /// <summary>
        /// An interactive object is found in webhooks related to interactive messages, including List Messages and Reply Button.
        /// </summary>
        [JsonProperty("interactive")]
        [JsonPropertyName("interactive")]
        public WebhookInteractiveReplyObject InteractiveReply { get; set; }

        [JsonProperty("button")]
        [JsonPropertyName("button")]
        public WebhookTemplateButtonReplyObject TemplateButtonReply { get; set; }

        /// <summary>
        /// Notifications of changes to the system.
        /// </summary>
        [JsonProperty("system")]
        [JsonPropertyName("system")]
        public WebhookSystemObject System { get; set; }

        /// <summary>
        /// An order object is found in webhooks related to Multi and Single Product Messages.
        /// </summary>
        [JsonProperty("order")]
        [JsonPropertyName("order")]
        public WebhookOrderObject Order { get; set; }

        [JsonProperty("errors")]
        [JsonPropertyName("errors")]
        public IEnumerable<ErrorObject> Errors { get; set; }

        /// <summary>
        /// This object is included in notifications when a user clicks on an ad that clicks to WhatsApp and sends a message to the business.
        /// </summary>
        [JsonProperty("referral")]
        [JsonPropertyName("referral")]
        public WebhookReferralObject Referral { get; set; }
    }
}
