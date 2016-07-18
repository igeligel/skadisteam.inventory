namespace skadisteam.inventory.Constants
{
    /// <summary>
    /// Class which includes all HTTP header values for the package.
    /// </summary>
    internal static class HttpHeaderValues
    {
        /// <summary>
        /// HTTP Header Value for the Accept-Language Header.
        /// </summary>
        internal const string AcceptLanguage =
            "en-GB,en-US;q=0.8,en;q=0.6,ru;q=0.4";
        
        /// <summary>
        /// HTTP Header Value for the Accept-Encoding Header.
        /// This will just tell the server it should return gzipped
        /// or deflated responses.
        /// </summary>
        internal const string GzipAndDeflate = "gzip, deflate";

        /// <summary>
        /// HTTP Header Value for the Accept-Encoding Header.
        /// This will just tell the server it should return gzipped,deflated,
        /// sdch or br responses.
        /// </summary>
        internal const string GzipDeflateSdhcAndBr = "gzip, deflate, sdch, br";

        /// <summary>
        /// HTTP Header Value for the several Headers.
        /// For example the value is used as value for
        /// the Pragma Header.
        /// </summary>
        internal const string NoCache = "no-cache";

        /// <summary>
        /// HTTP Header Value for the User-Agent Header.
        /// </summary>
        internal const string UserAgent =
            "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
    }
}
