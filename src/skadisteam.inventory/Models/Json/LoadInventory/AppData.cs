using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadInventory
{
    /// <summary>
    /// Specific information of an item. The propertie's
    /// value is related to the app which is requested.
    /// </summary>
    internal class AppData
    {
        /// <summary>
        /// Definition Index of the item.
        /// </summary>
        [JsonProperty(PropertyName = "def_index")]
        internal string DefIndex { get; set; }

        /// <summary>
        /// Value which describes if an item set name is
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "is_itemset_name")]
        internal int IsItemSetName { get; set; }

        /// <summary>
        /// Value which describes if an item was limited by
        /// Steam.
        /// </summary>
        [JsonProperty(PropertyName = "limited")]
        internal int Limited { get; set; }
    }
}
