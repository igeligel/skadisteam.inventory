using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class InnerDescription
    {
        [JsonProperty(PropertyName = "value")]
        internal string Value { get; set; }

        [JsonProperty(PropertyName = "type")]
        internal string Type { get; set; }

        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }
    }
}
