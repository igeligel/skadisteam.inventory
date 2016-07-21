namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Class which gives additional information to one
    /// description.
    /// </summary>
    public class SkadiItemDescription
    {
        /// <summary>
        /// Specific information of the app. For more information
        /// lookup <see cref="SkadiItemDescriptionAppData"/>.
        /// </summary>
        internal SkadiItemDescriptionAppData AppData { get; set; }

        /// <summary>
        /// Color of the description.
        /// </summary>
        internal string Color { get; set; }

        /// <summary>
        /// Type of the extra description.
        /// </summary>
        internal string Type { get; set; }

        /// <summary>
        /// Value regarding to the type of the description.
        /// </summary>
        internal string Value { get; set; }
    }
}
