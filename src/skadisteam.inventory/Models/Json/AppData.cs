using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class AppData
    {
        [JsonProperty(PropertyName = "def_index")]
        internal string DefIndex { get; set; }

        [JsonProperty(PropertyName = "is_itemset_name")]
        internal int IsItemSetName { get; set; }

        [JsonProperty(PropertyName = "limited")]
        internal int Limited { get; set; }
    }
}
