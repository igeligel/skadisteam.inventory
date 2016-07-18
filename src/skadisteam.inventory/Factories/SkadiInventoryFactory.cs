using System;
using skadisteam.inventory.Models;
using skadisteam.inventory.Models.Json;
using System.Collections.Generic;
using System.Linq;
using SkadiItemDescription = skadisteam.inventory.Models.SkadiItemDescription;

namespace skadisteam.inventory.Factories
{
    public static class SkadiInventoryFactory
    {
        internal static SkadiInventory Create(RootInventory rootInventory)
        {
            SkadiInventory skadiInventory = new SkadiInventory();
            skadiInventory.Items = new List<SkadiItem>();

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
                skadiItem.Description = new List<SkadiItemDescription>();

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

                    skadiItemDescription.AppData = new AppData();

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
                skadiItem.Tags = new List<SkadiItemTag>();
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