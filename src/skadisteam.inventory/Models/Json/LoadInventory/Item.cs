using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadInventory
{
    /// <summary>
    /// Json Model for an item in the rgInventory object.
    /// It represents just the bare item without any metainformation.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Asset Id of the item, which is used in several trading parts.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        internal long Id { get; set; }

        /// <summary>
        /// Class id which is identifying the item.
        /// </summary>
        [JsonProperty(PropertyName = "classid")]
        internal long ClassId { get; set; }

        /// <summary>
        /// Id to differentiate between items with the same class id.
        /// </summary>
        [JsonProperty(PropertyName = "instanceid")]
        internal long InstanceId { get; set; }

        /// <summary>
        /// Amount of items. This is only used for special items
        /// like gems of the Steam Community.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        internal int Amount { get; set; }

        /// <summary>
        /// Position of the item.
        /// </summary>
        [JsonProperty(PropertyName = "pos")]
        internal int Pos { get; set; }
    }
}
