using System;

namespace skadisteam.inventory.Constants
{
    /// <summary>
    /// Class which contains all the URI's used in the package.
    /// </summary>
    internal static class Uris
    {
        /// <summary>
        /// URI for the Steam community base resource.
        /// Lookup: <see cref="Resources"/>.
        /// </summary>
        internal static Uri SteamCommunityBase =
            new Uri(Resources.SteamCommunityBase);

        /// <summary>
        /// URI for the Steam community base resource. But this
        /// one is taking the secured URL.
        /// Lookup: <see cref="Resources"/>.
        /// </summary>
        internal static Uri SteamCommunityBaseSecured =
            new Uri(Resources.SteamCommunityBaseSecured);
    }
}
