using System;
using skadisteam.inventory.Models;
using skadisteam.inventory.Models.Json;
using System.Collections.Generic;
using System.Linq;
using SkadiItemDescription = skadisteam.inventory.Models.SkadiItemDescription;
using skadisteam.inventory.Interfaces;

namespace skadisteam.inventory.Factories
{
    /// <summary>
    /// Factory for creating the inventory instance of Skadisteam.
    /// </summary>
    internal static class SkadiInventoryFactory
    {
        /// <summary>
        /// Create a SkadiInventory out of the JSON response of
        /// the steam community api.
        /// </summary>
        /// <param name="rootInventory">
        /// JSON Model of the response. For further information
        /// lookup <see cref="RootInventory"/>.
        /// </param>
        /// <returns>
        /// An instance of <see cref="SkadiInventory"/> which includes 
        /// a simple model for the steam inventory.
        /// </returns>
        internal static SkadiInventory Create(RootInventory rootInventory)
        {
            SkadiInventory skadiInventory = new SkadiInventory();
            skadiInventory.Items = new List<ISkadiItem>();

            var descriptions = rootInventory.Descriptions;
            var inventory = rootInventory.Inventory;

            foreach (KeyValuePair<string, Item> entry in inventory)
            {
                SkadiItem skadiItem = new SkadiItem();
                skadiItem.Amount = entry.Value.Amount;
                skadiItem.ClassId = entry.Value.ClassId;
                skadiItem.InstanceId = entry.Value.InstanceId;
                skadiItem.AssetId = entry.Value.Id;
                skadiItem.Position = entry.Value.Pos;

                var description =
                    descriptions.FirstOrDefault(
                        e =>
                            e.Key ==
                            skadiItem.ClassId + "_" + skadiItem.InstanceId);

                skadiItem.BackgroundColor = description.Value.BackgroundColor;
                skadiItem.Commodity = description.Value.Commodity;
                skadiItem.Description = new List<ISkadiItemDescription>();

                foreach (var innerDescription in description.Value.Descriptions)
                {
                    var skadiItemDescription = new SkadiItemDescription
                    {
                        Color = innerDescription.Color,
                        Type = innerDescription.Type,
                        Value = innerDescription.Value
                    };
                    if (innerDescription.AppData == null)
                    {
                        continue;
                    }

                    skadiItemDescription.AppData = new SkadiItemDescriptionAppData();

                    skadiItemDescription.AppData.DefIndex =
                    innerDescription.AppData.DefIndex;
                    skadiItemDescription.AppData.IsItemSetName =
                        innerDescription.AppData.IsItemSetName;
                    skadiItemDescription.AppData.Limited =
                        innerDescription.AppData.Limited;

                    skadiItem.Description.Add(skadiItemDescription);
                }

                skadiItem.IconDragUrl = description.Value.IconDragUrl;
                skadiItem.IconUrl = description.Value.IconUrl;
                skadiItem.MarketHashName = description.Value.MarketHashName;
                skadiItem.MarketName = description.Value.MarketName;
                skadiItem.MarketTradableRestriction = description.Value.MarketTradableRestriction;
                skadiItem.Name = description.Value.Name;
                skadiItem.NameColor = description.Value.NameColor;
                skadiItem.Tags = new List<ISkadiItemTag>();
                foreach (var innerTag in description.Value.Tags)
                {
                    SkadiItemTag skadiItemTag = new SkadiItemTag
                    {
                        Category = innerTag.Category,
                        CategoryName = innerTag.CategoryName,
                        Color = innerTag.Color,
                        InternalName = innerTag.InternalName,
                        Name = innerTag.Name
                    };
                    skadiItem.Tags.Add(skadiItemTag);
                }
                skadiItem.Tradable = description.Value.Tradable;
                skadiItem.Type = description.Value.Type;

                skadiInventory.Items.Add(skadiItem);
            }
            return skadiInventory;
        }
    }
}
