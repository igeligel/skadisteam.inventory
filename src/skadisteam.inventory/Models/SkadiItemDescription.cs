using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Class which gives additional information to one
    /// description.
    /// </summary>
    public class SkadiItemDescription: ISkadiItemDescription
    {
        /// <summary>
        /// Specific information of the app. For more information
        /// lookup <see cref="ISkadiItemDescriptionAppData"/>.
        /// </summary>
        public ISkadiItemDescriptionAppData AppData { get; set; }

        /// <summary>
        /// Color of the description.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Type of the extra description.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Value regarding to the type of the description.
        /// </summary>
        public string Value { get; set; }
    }
}
