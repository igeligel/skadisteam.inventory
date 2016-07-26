using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory
{
    /// <summary>
    /// Tags for items used. There are different types which
    /// are differentiated by the category.
    /// This tag contains additional information of the item.
    /// </summary>
    public class SkadiItemTag: ISkadiItemTag
    {
        /// <summary>
        /// Category of the tag.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Name of the category.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Color of the category.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Internal name of the tag.
        /// </summary>
        public string InternalName { get; set; }

        /// <summary>
        /// Name of the tag to show.
        /// </summary>
        public string Name { get; set; }
    }
}
