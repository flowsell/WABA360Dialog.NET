using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WABA360Dialog.ApiClient.Payloads.Models.WebhookObjects
{
    public class WebhookOrderObject
    {
        /// <summary>
        /// ID of the catalog that contains the products listed under product_items sections.
        /// </summary>
        [JsonProperty("catalog_id")]
        [JsonPropertyName("catalog_id")]
        public string CatalogId { get; set; }

        /// <summary>
        /// Array of product items.
        /// </summary>
        [JsonProperty("product_items")]
        [JsonPropertyName("product_items")]
        public IEnumerable<WebhookProductItemsObject> ProductItems { get; set; }

        /// <summary>
        /// Text message sent along with the order.
        /// </summary>
        [JsonProperty("text")]
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
