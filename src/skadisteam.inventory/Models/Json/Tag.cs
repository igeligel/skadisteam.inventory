using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class Tag
    {
        [JsonProperty(PropertyName = "internal_name")]
        internal string InternalName { get; set; }

        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }

        [JsonProperty(PropertyName = "category")]
        internal string Category { get; set; }

        [JsonProperty(PropertyName = "category_name")]
        internal string CategoryName { get; set; }

        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }
    }
}
