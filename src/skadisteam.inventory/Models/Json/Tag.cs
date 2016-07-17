using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    public class Tag
    {
        [JsonProperty(PropertyName = "internal_name")]
        public string InternalName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        [JsonProperty(PropertyName = "category_name")]
        public string CategoryName { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }
    }
}
