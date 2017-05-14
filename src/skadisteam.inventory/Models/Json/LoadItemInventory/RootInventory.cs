using System.Collections.Generic;
using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class RootInventory
    {
        [JsonProperty(PropertyName = "assets")]
        internal List<Asset> Assets { get; set; }

        [JsonProperty(PropertyName = "descriptions")]
        internal List<Description> Descriptions { get; set; }

        [JsonProperty(PropertyName = "total_inventory_count")]
        internal int TotalInventoryCount { get; set; }

        [JsonProperty(PropertyName = "success")]
        internal int Success { get; set; }

        [JsonProperty(PropertyName = "rwgrsn")]
        internal int Rwgrsn { get; set; }
    }
}
