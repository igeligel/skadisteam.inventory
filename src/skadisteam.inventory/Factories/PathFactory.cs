using skadisteam.inventory.Extensions;

namespace skadisteam.inventory.Factories
{
    internal class PathFactory
    {
        internal static string CreatePublicInventoryPath(
            long communityPartnerId, int appId, int contextId,
            bool tradableItems)
        {
            var path = "/profiles/" + communityPartnerId +
                       "/inventory/json/" +
                       appId + "/" + contextId;
            if (tradableItems)
            {
                path = path.AddNewTradableItemParameter();
            }
            return path;
        }

        internal static string CreatePartnerInventoryPath(string sessionId,
            long partnerCommunityId, int appId, int contextId,
            bool tradableItems)
        {
            var path = "/tradeoffer/new/partnerinventory/?sessionid=" +
                       sessionId + "&partner=" + partnerCommunityId + "&appid=" +
                       appId + "&contextid=" + contextId;
            if (tradableItems)
            {
                path = path.AddNewTradableItemParameter();
            }
            return path;
        }
    }
}