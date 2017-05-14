using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class Action
    {
        [JsonProperty(PropertyName = "link")]
        internal string Link { get; set; }

        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }
    }
}
