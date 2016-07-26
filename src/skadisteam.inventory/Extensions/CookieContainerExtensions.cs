using System.Net;
using skadisteam.inventory.Constants;

namespace skadisteam.inventory.Extensions
{
    /// <summary>
    /// Class which provide extensions for the CookieContainer class.
    /// Lookup; <see cref="CookieContainer"/>.
    /// </summary>
    internal static class CookieContainerExtensions
    {
        /// <summary>
        /// Add the steam language cookie to the <see cref="CookieContainer"/>,
        /// given as parameter.
        /// </summary>
        /// <param name="cookieContainer">
        /// <see cref="CookieContainer"/> which the cookie should be added to.
        /// </param>
        /// <returns>
        /// The <see cref="CookieContainer"/> with appended steam language cookie.
        /// </returns>
        internal static CookieContainer AddEnglishSteamLanguageCookie(
            this CookieContainer cookieContainer)
        {
            var cookie = new Cookie(CookieKeys.SteamLanguage,
                CookieValues.SteamLanguage, "",
                Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }

        /// <summary>
        /// Add the steam session cookie to the <see cref="CookieContainer"/>,
        /// given as parameter.
        /// </summary>
        /// <param name="cookieContainer">
        /// <see cref="CookieContainer"/> which the cookie should be added to.
        /// </param>
        /// <param name="sessionId">
        /// Session Id which is grabbed at some steam site.
        /// </param>
        /// <returns>
        /// The <see cref="CookieContainer"/> with appended steam session cookie.
        /// </returns>
        internal static CookieContainer AddSteamSessionIdCookie(
            this CookieContainer cookieContainer, string sessionId)
        {
            var cookie = new Cookie(CookieKeys.SessionId, sessionId, "/",
                Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }

        /// <summary>
        /// Add the steam login secure cookie to the <see cref="CookieContainer"/>,
        /// given as parameter.
        /// </summary>
        /// <param name="cookieContainer">
        /// <see cref="CookieContainer"/> which the cookie should be added to.
        /// </param>
        /// <param name="steamLoginSecure">
        /// Steam Login Secure Cookie Value.
        /// </param>
        /// <returns>
        /// The <see cref="CookieContainer"/> with 
        /// the appended steam login secure cookie.
        /// </returns>
        internal static CookieContainer AddSteamLoginSecureCookie(
            this CookieContainer cookieContainer, string steamLoginSecure)
        {
            var cookie = new Cookie(CookieKeys.SteamLoginSecure,
                steamLoginSecure, "/", Uris.SteamCommunityBaseSecured.Host);
            cookieContainer.Add(Uris.SteamCommunityBaseSecured, cookie);
            return cookieContainer;
        }
    }
}
