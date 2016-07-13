using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    internal class AppInfo
    {
        [JsonProperty(PropertyName = "appid")]
        internal int AppId { get; set; }

        [JsonProperty(PropertyName = "icon")]
        internal string Icon { get; set; }

        [JsonProperty(PropertyName = "link")]
        internal string Link { get; set; }

        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }
    }
}
