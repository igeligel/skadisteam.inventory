using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json.LoadInventory
{
    /// <summary>
    /// Information about the app which is the inventory
    /// requested to.
    /// </summary>
    internal class AppInfo
    {
        /// <summary>
        /// Id of the app. This is specified by Steam. For example
        /// Counter-Strike: Global Offensive has the app id 730.
        /// </summary>
        [JsonProperty(PropertyName = "appid")]
        internal int AppId { get; set; }

        /// <summary>
        /// URL to the icon of the app.
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        internal string Icon { get; set; }

        /// <summary>
        /// Store link to the app.
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        internal string Link { get; set; }

        /// <summary>
        /// Name of the app.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        internal string Name { get; set; }
    }
}
