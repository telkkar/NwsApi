using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace NwsApi
{
    public class NwsDataLoader: INwsDataLoader
    {
        #region Constructors

        /// <summary>
        /// There is no valid default constructor if we require a custom user agent defined by the consumer
        /// </summary>
        private NwsDataLoader()
        {

        }

        /// <summary>
        /// Create an NwsDataLoader that will load data from the NWS API
        /// </summary>
        /// <param name="httpClient">httpClient to use to communicate to the API</param>
        /// <param name="customUserAgent">User Agent to identify the consumer. Will have NwsApi specific information
        /// added. Must easily identify the consumer in case of NWS information request</param>
        /// <exception cref="ArgumentNullException">Thrown if HttpClient or customUserAgent is not provided</exception>
        /// <exception cref="ArgumentException">Thrown if customUserAgent is not valid</exception>
        public NwsDataLoader(HttpClient httpClient, string customUserAgent)
        {
            if (httpClient == null)
            {
                throw new ArgumentNullException(nameof(httpClient), $"HttpClient is required for {nameof(NwsDataLoader)} to work");
            }

            if (string.IsNullOrEmpty(customUserAgent))
            {
                throw new ArgumentNullException(nameof(customUserAgent), $"{nameof(customUserAgent)} must be provided for {nameof(NwsDataLoader)} to work correctly");
            }

            if (!CanUseUserAgent(customUserAgent))
            {
                throw new ArgumentException("Provided user agent string was not valid.", nameof(customUserAgent));
            }

            httpClient.BaseAddress = new Uri("https://api.weather.gov/");
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("NwsApi (Website: https://github.com/telkkar/NwsApi)");
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(customUserAgent);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/ld+json"));
            httpClient.Timeout = new TimeSpan(0, 0, 0, 60);

            this.HttpClient = httpClient;
        }

        #endregion

        #region Properties

        private HttpClient HttpClient { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Retrieve the response stream from the NWS API
        /// </summary>
        /// <param name="subDirectoryPath">Path to the API endpoint underneath the NWS API root</param>
        /// <returns>Response stream of requested resource</returns>
        public Stream GetResponseStream(string subDirectoryPath)
        {
            var response = HttpClient.GetStreamAsync(subDirectoryPath);

            // TODO: Catch exceptions?
            return response.GetAwaiter().GetResult();
        }

        /// <summary>
        /// Test to see whether or not the user agent is usable
        /// </summary>
        /// <param name="customUserAgent">User Agent string to test</param>
        /// <returns>True if valid, False if it will throw exceptions when parsed</returns>
        public static bool CanUseUserAgent(string customUserAgent)
        {
            ProductInfoHeaderValue unused = null;
            return ProductInfoHeaderValue.TryParse(customUserAgent, out unused);
        }

        #endregion
    }
}
