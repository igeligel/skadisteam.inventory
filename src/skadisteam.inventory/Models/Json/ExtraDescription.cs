using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    public class ExtraDescription
    {
        [JsonProperty(PropertyName = "app_data")]
        public AppData AppData { get; set; }

        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
