namespace skadisteam.inventory.Interfaces
{
    /// <summary>
    /// Tags for items used. There are different types which
    /// are differentiated by the category.
    /// This tag contains additional information of the item.
    /// </summary>
    public interface ISkadiItemTag
    {
        /// <summary>
        /// Category of the tag.
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        string CategoryName { get; set; }

        /// <summary>
        /// Color of the category.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// Internal name of the tag.
        /// </summary>
        string InternalName { get; set; }

        /// <summary>
        /// Name of the tag to show.
        /// </summary>
        string Name { get; set; }
    }
}
