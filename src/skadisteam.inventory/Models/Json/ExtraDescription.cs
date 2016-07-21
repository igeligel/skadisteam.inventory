using Newtonsoft.Json;

namespace skadisteam.inventory.Models.Json
{
    /// <summary>
    /// Class which gives additional information to one
    /// description.
    /// </summary>
    internal class ExtraDescription
    {
        /// <summary>
        /// Specific information of the app. For more information
        /// lookup <see cref="AppData"/>.
        /// </summary>
        [JsonProperty(PropertyName = "app_data")]
        internal AppData AppData { get; set; }

        /// <summary>
        /// Color of the description.
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        internal string Color { get; set; }

        /// <summary>
        /// Type of the extra description.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        internal string Type { get; set; }

        /// <summary>
        /// Value regarding to the type of the description.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        internal string Value { get; set; }
    }
}
