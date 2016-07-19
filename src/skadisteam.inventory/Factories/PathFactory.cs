using skadisteam.inventory.Extensions;

namespace skadisteam.inventory.Factories
{
    /// <summary>
    /// Factory to create paths used in the package.
    /// </summary>
    internal class PathFactory
    {
        /// <summary>
        /// Method to creates the path to a public inventory.
        /// This will just create the path and ignores the base
        /// path.
        /// </summary>
        /// <param name="steamCommunityPartnerId">
        /// The Steam Community Partner Id. It is also referenced as
        /// 64-Bit Steam Id. 76561198028630048 for example is the 
        /// Steam Community Partner Id of my profile.
        /// </param>
        /// <param name="appId">
        /// Every game in steam has an App Id. This App Id is used for
        /// referencing the inventory to a game. 730 for example is the
        /// App Id for Counter-Strike: Global Offensive.
        /// </param>
        /// <param name="contextId">
        /// This is a game specific Id to differentiate between multiple
        /// types of inventories in one game.
        /// </param>
        /// <param name="tradableItems">
        /// Parameter to describe if you just want to get tradable items
        /// of the inventory.
        /// </param>
        /// <returns>
        /// The path to the inventory based on the parameters given.
        /// </returns>
        internal static string CreatePublicInventoryPath(
            long steamCommunityPartnerId, int appId, int contextId,
            bool tradableItems)
        {
            var path = "/profiles/" + steamCommunityPartnerId +
                       "/inventory/json/" +
                       appId + "/" + contextId;
            if (tradableItems)
            {
                path = path.AddNewTradableItemParameter();
            }
            return path;
        }

        /// <summary>
        /// Method to create the path for partner inventory. This is used
        /// when you access private profiles which you are friended with.
        /// </summary>
        /// <param name="sessionId">
        /// Id of your current session which is needed for creating the
        /// path.
        /// </param>
        /// <param name="steamCommunityPartnerId">
        /// The Steam Community Partner Id. It is also referenced as
        /// 64-Bit Steam Id. 76561198028630048 for example is the 
        /// Steam Community Partner Id of my profile.
        /// </param>
        /// <param name="appId">
        /// Every game in steam has an App Id. This App Id is used for
        /// referencing the inventory to a game. 730 for example is the
        /// App Id for Counter-Strike: Global Offensive.
        /// </param>
        /// <param name="contextId">
        /// This is a game specific Id to differentiate between multiple
        /// types of inventories in one game.
        /// </param>
        /// <param name="tradableItems">
        /// Parameter to describe if you just want to get tradable items
        /// of the inventory.
        /// </param>
        /// <returns>
        /// The path to the partner inventory.
        /// </returns>
        internal static string CreatePartnerInventoryPath(string sessionId,
            long steamCommunityPartnerId, int appId, int contextId,
            bool tradableItems)
        {
            var path = "/tradeoffer/new/partnerinventory/?sessionid=" +
                       sessionId + "&partner=" + steamCommunityPartnerId + "&appid=" +
                       appId + "&contextid=" + contextId;
            if (tradableItems)
            {
                path = path.AddNewTradableItemParameter();
            }
            return path;
        }
    }
}
