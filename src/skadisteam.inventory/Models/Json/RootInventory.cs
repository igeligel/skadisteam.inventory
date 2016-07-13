using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class RootInventory
    {
        [JsonProperty(PropertyName = "more")]
        internal bool More { get; set; }

        [JsonProperty(PropertyName = "more_start")]
        internal bool MoreStart { get; set; }

        [JsonProperty(PropertyName = "rgCurrency")]
        internal List<object> Currencies { get; set; }

        [JsonProperty(PropertyName = "rgDescriptions")]
        internal Dictionary<string, Description> Descriptions { get; set; }

        [JsonProperty(PropertyName = "rgInventory")]
        internal Dictionary<string, object> Inventory { get; set; }

        [JsonProperty(PropertyName = "success")]
        internal bool Success { get; set; }
    }
}
