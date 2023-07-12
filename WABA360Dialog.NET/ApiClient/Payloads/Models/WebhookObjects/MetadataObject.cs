using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class MetadataObject
    {
        [JsonProperty("android-app-store-link")]
        [JsonPropertyName("android-app-store-link")]
        public string AndroidAppStoreLink { get; set; }

        [JsonProperty("emojis")]
        [JsonPropertyName("emojis")]
        public IEnumerable<string> Emojis { get; set; }

        [JsonProperty("ios-app-store-link")]
        [JsonPropertyName("ios-app-store-link")]
        public string IosAppStoreLink { get; set; }

        [JsonProperty("is-first-party-sticker")]
        [JsonPropertyName("is-first-party-sticker")]
        public int IsFirstPartySticker { get; set; }

        [JsonProperty("sticker-pack-id")]
        [JsonPropertyName("sticker-pack-id")]
        public string StickerPackId { get; set; }

        [JsonProperty("sticker-pack-name")]
        [JsonPropertyName("sticker-pack-name")]
        public string StickerPackName { get; set; }

        [JsonProperty("sticker-pack-publisher")]
        [JsonPropertyName("sticker-pack-publisher")]
        public string StickerPackPublisher { get; set; }
    }
}
