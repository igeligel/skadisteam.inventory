using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadItemInventory
{
    internal class Tag
    {
        [JsonProperty(PropertyName = "category")]
        internal string Category { get; set; }

        [JsonProperty(PropertyName = "internal_name")]
        internal string InternalName { get; set; }

        [JsonProperty(PropertyName = "localized_category_name")]
        internal string LocalizedCategoryName { get; set; }

        [JsonProperty(PropertyName = "localized_tag_name")]
        internal string LocalizedTagName { get; set; }

        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }
    }
}
