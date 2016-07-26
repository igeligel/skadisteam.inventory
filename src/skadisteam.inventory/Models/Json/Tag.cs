using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    /// <summary>
    /// Tags for items used. There are different types which
    /// are differentiated by the category.
    /// This tag contains additional information of the item.
    /// </summary>
    internal class Tag
    {
        /// <summary>
        /// Internal name of the tag.
        /// </summary>
        [JsonProperty(PropertyName = "internal_name")]
        internal string InternalName { get; set; }

        /// <summary>
        /// Name of the tag to show.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }

        /// <summary>
        /// Category of the tag.
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        internal string Category { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        [JsonProperty(PropertyName = "category_name")]
        internal string CategoryName { get; set; }

        /// <summary>
        /// Color of the category.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }
    }
}
