using System.Collections.Generic;

namespace skadisteam.inventory.Interfaces
{
    /// <summary>
    /// Interface to define a data structure which holds all items
    /// of an inventory. This will just hold a list of
    /// <see cref="ISkadiItem"/>. This model is simplified and
    /// not based on dictionaries which make working with
    /// inventories easier.
    /// </summary>
    public interface ISkadiInventory
    {
        /// <summary>
        /// List of <see cref="ISkadiItem"/>.
        /// </summary>
        List<ISkadiItem> Items { get; set; }
    }
}
