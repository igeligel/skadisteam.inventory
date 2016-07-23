namespace skadisteam.inventory.Interfaces
{
    public interface ISkadiItemDescription
    {
        /// <summary>
        /// Specific information of the app. For more information
        /// lookup <see cref="SkadiItemDescriptionAppData"/>.
        /// </summary>
        ISkadiItemDescriptionAppData AppData { get; set; }

        /// <summary>
        /// Color of the description.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// Type of the extra description.
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Value regarding to the type of the description.
        /// </summary>
        string Value { get; set; }
    }
}
