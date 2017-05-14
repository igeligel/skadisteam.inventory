using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class Asset
    {
        [JsonProperty(PropertyName = "appid")]
        internal string AppId { get; set; }

        [JsonProperty(PropertyName = "contextid")]
        internal string ContextId { get; set; }

        [JsonProperty(PropertyName = "assetid")]
        internal string AssetId { get; set; }

        [JsonProperty(PropertyName = "classid")]
        internal string ClassId { get; set; }

        [JsonProperty(PropertyName = "instanceid")]
        internal string InstanceId { get; set; }

        [JsonProperty(PropertyName = "amount")]
        internal string Amount { get; set; }
    }
}
