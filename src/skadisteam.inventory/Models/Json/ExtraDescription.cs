using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class ExtraDescription
    {
        [JsonProperty(PropertyName = "app_data")]
        internal AppData AppData { get; set; }

        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }

        [JsonProperty(PropertyName = "type")]
        internal string Type { get; set; }

        [JsonProperty(PropertyName = "value")]
        internal string Value { get; set; }
    }
}
