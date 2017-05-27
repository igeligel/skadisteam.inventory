using skadisteam.inventory.Models;
using System.Collections.Generic;
using System.Linq;
using SkadiItemDescription = skadisteam.inventory.Models.SkadiItemDescription;
using skadisteam.inventory.Interfaces;
using skadisteam.inventory.Models.Json.LoadInventory;
using skadisteam.inventory.Models.SkadiItemInventory;
using SkadiItem = skadisteam.inventory.Models.SkadiItem;
using SkadiItemTag = skadisteam.inventory.Models.SkadiItemTag;

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
            var skadiInventory = new SkadiInventory();
            skadiInventory.Items = new List<ISkadiItem>();

            var descriptions = rootInventory.Descriptions;
            var inventory = rootInventory.Inventory;

            foreach (var entry in inventory)
            {
                var skadiItem = new SkadiItem();
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

                if (description.Value.Descriptions != null)
                {
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

        internal static SkadiItemInventory CreateNew(
            Models.Json.LoadItemInventory.RootInventory rootInventory)
        {
            var skadiItemInventory =
                new SkadiItemInventory
                {
                    Rwgrsn = rootInventory.Rwgrsn,
                    Items = new List<Models.SkadiItemInventory.SkadiItem>()
                };
            if (rootInventory.Assets == null)
            {
                return skadiItemInventory;
            }
            foreach (var rootInventoryAsset in rootInventory.Assets)
            {
                var descriptionForItem =
                    rootInventory.Descriptions.FirstOrDefault(
                        e => e.ClassId == rootInventoryAsset.ClassId &&
                             e.InstanceId == rootInventoryAsset.InstanceId);
                var skadiItem = new Models.SkadiItemInventory.SkadiItem();
                skadiItem.ContextId = int.Parse(rootInventoryAsset.ContextId);
                skadiItem.Amount = int.Parse(rootInventoryAsset.Amount);
                skadiItem.AppId = int.Parse(rootInventoryAsset.AppId);
                skadiItem.AssetId = long.Parse(rootInventoryAsset.AssetId);
                skadiItem.ClassId = long.Parse(rootInventoryAsset.ClassId);
                skadiItem.InstanceId = long.Parse(rootInventoryAsset.InstanceId);

                skadiItem.Actions = new List<SkadiItemAction>();
                if (descriptionForItem.Actions != null)
                {
                    foreach (var action in descriptionForItem.Actions)
                    {
                        skadiItem.Actions.Add(new SkadiItemAction
                        {
                            Link = action.Link,
                            Name = action.Name
                        });
                    }
                }

                skadiItem.Descriptions = new List<Models.SkadiItemInventory.SkadiItemDescription>();
                foreach (var innerDescription in descriptionForItem.Descriptions)
                {
                    skadiItem.Descriptions.Add(
                        new Models.SkadiItemInventory.SkadiItemDescription
                        {
                            Type = innerDescription.Type,
                            Color = innerDescription.Color,
                            Value = innerDescription.Value
                        });
                }

                skadiItem.Tags = new List<Models.SkadiItemInventory.SkadiItemTag>();
                foreach (var tag in descriptionForItem.Tags)
                {
                    skadiItem.Tags.Add(
                        new Models.SkadiItemInventory.SkadiItemTag
                        {
                            Color = tag.Color,
                            Category = tag.Category,
                            InternalName = tag.InternalName,
                            LocalizedCategoryName = tag.LocalizedCategoryName,
                            LocalizedTagName = tag.LocalizedTagName
                        });
                }

                skadiItem.BackgroundColor = descriptionForItem.BackgroundColor;
                skadiItem.Type = descriptionForItem.Type;
                skadiItem.Tradable = descriptionForItem.Tradable == 1;
                skadiItem.Name = descriptionForItem.Name;
                skadiItem.Marketable = descriptionForItem.Marketable == 1;
                skadiItem.MarketTradableRestriction = descriptionForItem
                    .MarketTradableRestriction;
                skadiItem.MarketName = descriptionForItem.MarketName;
                skadiItem.MarketMarketableRestriction = descriptionForItem
                    .MarketMarketableRestriction;
                skadiItem.MarketHashName = descriptionForItem.MarketHashName;
                skadiItem.MarketFeeApp = descriptionForItem.MarketFeeApp;
                skadiItem.IconUrlLarge = descriptionForItem.IconUrlLarge;
                skadiItem.IconUrl = descriptionForItem.IconUrl;
                skadiItem.Currency = descriptionForItem.Currency;
                skadiItem.Commodity = descriptionForItem.Commodity;

                skadiItemInventory.Items.Add(skadiItem);
            }
            return skadiItemInventory;
        }
    }
}
