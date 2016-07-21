using System.Collections.Generic;

namespace skadisteam.inventory.Models
{
    /// <summary>
    /// Class to define a data structure which holds all items
    /// of an inventory. This will just hold a list of
    /// <see cref="SkadiItem"/>. This model is simplified and
    /// not based on dictionaries which make working with
    /// inventories easier.
    /// </summary>
    public class SkadiInventory
    {
        /// <summary>
        /// List of <see cref="SkadiItem"/>.
        /// </summary>
        public List<SkadiItem> Items { get; set; }
    }
}
