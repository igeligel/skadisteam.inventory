namespace skadisteam.inventory.Factories
{
    internal class PathFactory
    {
        internal static string CreatePublicInventoryPath(
            long communityPartnerId, int appId, int contextId)
        {
            return "/profiles/" + communityPartnerId + "/inventory/json/" +
                   appId + "/" + contextId;
        }
    }
}