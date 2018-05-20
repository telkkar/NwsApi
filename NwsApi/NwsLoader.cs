using System;
using System.Net.Http;

namespace NwsApi
{
    /// <summary>
    /// Loads information from the National Weather Service
    /// </summary>
    /// <see href="https://forecast-v3.weather.gov/documentation"/>
    // TODO: Rename this class to a better "this is an API consumers should use" name
    public class NwsLoader
    {
        #region Constructors

        public NwsLoader() : this(new HttpClient())
        {

        }

        /// <summary>
        /// Constructor to use if consumers have premade an HttpClient
        /// </summary>
        /// <param name="httpClient"></param>
        public NwsLoader(HttpClient httpClient)
        {
            this.HttpClient = httpClient;
        }

        #endregion

        #region Properties

        // TODO: Remove direct reliance on HttpClient so we can write tests that parse pre-selected responses
        private HttpClient HttpClient { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="latitude">EPSG:4326 latitude</param>
        /// <param name="longitude">EPSG:4326 longitude</param>
        /// <returns>NwsPoint containing information about the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPoint PointData(double latitude, double longitude)
        {
            throw new NotImplementedException(nameof(PointData) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/forecast
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="latitude">EPSG:4326 latitude</param>
        /// <param name="longitude">EPSG:4326 longitude</param>
        /// <returns>NwsPointForecast containing forecast information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointForecast PointForecast(double latitude, double longitude)
        {
            throw new NotImplementedException(nameof(PointForecast) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/forecast
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="nwsPoint">Point specifying the location</param>
        /// <returns>NwsPointForecast containing forecast information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointForecast PointForecast(NwsPoint nwsPoint)
        {
            throw new NotImplementedException(nameof(PointForecast) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/forecast
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="latitude">EPSG:4326 latitude</param>
        /// <param name="longitude">EPSG:4326 longitude</param>
        /// <returns>NwsPointForcastHourly containing hourly forecast information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointForecastHourly PointForecastHourly(double latitude, double longitude)
        {
            throw new NotImplementedException(nameof(PointForecastHourly) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/forecast
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="nwsPoint">Point specifying the location</param>
        /// <returns>NwsPointForcastHourly containing hourly forecast information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointForecastHourly PointForecastHourly(NwsPoint nwsPoint)
        {
            throw new NotImplementedException(nameof(PointForecastHourly) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/stations
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="latitude">EPSG:4326 latitude</param>
        /// <param name="longitude">EPSG:4326 longitude</param>
        /// <returns>NwsPointStations containing nearby station information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointStations PointStations(double latitude, double longitude)
        {
            throw new NotImplementedException(nameof(PointStations) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /points/{latitude,longitude}/stations
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="nwsPoint">Point specifying the location</param>
        /// <returns>NwsPointStations containing nearby station information for the specified point</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsPointStations PointStations(NwsPoint nwsPoint)
        {
            throw new NotImplementedException(nameof(PointStations) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /gridpoints/{wfo}/{x},{y} API endpoint
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="weatherForecastOfficeId">Weather Forecast Office identifier. https://en.wikipedia.org/wiki/List_of_National_Weather_Service_Weather_Forecast_Offices</param>
        /// <param name="x">x coordinate on the grid</param>
        /// <param name="y">y coordinate on the grid</param>
        /// <returns>NwsGridpoint containing information about the grid at x,y</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsGridpoint GridpointData(string weatherForecastOfficeId, int x, int y)
        {
            throw new NotImplementedException(nameof(GridpointData) + " not implemented");
        }

        #endregion

    }
}
