using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    public class AppData
    {
        [JsonProperty(PropertyName = "def_index")]
        public string DefIndex { get; set; }

        [JsonProperty(PropertyName = "is_itemset_name")]
        public int IsItemSetName { get; set; }

        [JsonProperty(PropertyName = "limited")]
        public int Limited { get; set; }
    }
}
