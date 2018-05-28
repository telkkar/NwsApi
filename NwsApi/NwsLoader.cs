using System;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using NwsApi.Models;

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

        private NwsLoader()
        {

        }

        /// <summary>
        /// Create a fancy new NwsLoader
        /// </summary>
        /// <param name="nwsDataLoader">Implements INwsDataLoader</param>
        public NwsLoader(INwsDataLoader nwsDataLoader)
        {
            this.NwsDataLoader = nwsDataLoader;
        }

        #endregion

        #region Properties

        private INwsDataLoader NwsDataLoader { get; set; }

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
        public NwsPoint PointData(double latitude, double longitude)
        {
            NwsPoint nwsPoint;

            var stream = NwsDataLoader.GetResponseStream($"/points/{latitude},{longitude}");

            using (var sr = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(sr))
            {
                var jsonSerializer = new JsonSerializer();
                nwsPoint = jsonSerializer.Deserialize<NwsPoint>(jsonReader);
            }

            return nwsPoint;
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

        /// <summary>
        /// Wrapper for /stations
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="stationIds">String of comma-separated station ids</param>
        /// <param name="stateCodes">String of comma-separated state codes</param>
        /// <param name="limit">Max number of stations to load</param>
        /// <returns>Information about the stations found</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsStations Stations(string stationIds, string stateCodes, int limit = 10)
        {
            throw new NotImplementedException(nameof(Stations) + " not implemented");
        }

        /// <summary>
        /// Wrapper for /stations
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="stationIds">Enumerable container of station ids</param>
        /// <param name="stateCodes">Enumerable container of state codes</param>
        /// <param name="limit">Max number of stations to load</param>
        /// <returns>Information about the stations found</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsStations Stations(IEnumerable stationIds, IEnumerable stateCodes, int limit = 10)
        {
            throw new NotImplementedException(nameof(Stations) + " not implemented");
        }
        /// <summary>
        /// Wrapper for /stations/{stationId}/
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="stationId">Station id to load data for</param>
        /// <returns>Information about the station</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsStations StationData(string stationId)
        {
            throw new NotImplementedException(nameof(StationData) + " not implemented");
        }

        /*
         * The following are documentation stubs for now. There's not an immediate foreseeable use for these,
         * so they're going to remain documentation TODOs for now and will be reviewed later.
         */
        // TODO: Wrapper for /stations/{stationId}/observations

        // TODO: Wrapper for /stations/{stationId}/observations/current

        // TODO: Wrapper for /stations/{stationId}/observations/{recordId}


        // TODO: Wrapper for /products/{productId}

        // TODO: Wrapper for /products/types

        // TODO: Wrapper for /products/types/{typeId}

        // TODO: Wrapper for /products/types/{typeId}/locations

        // TODO: Wrapper for /products/types/{typeId}/locations/{locationId}

        // TODO: Wrapper for /products/locations

        // TODO: Wrapper for /products/locations/{locationId}/types


        /// <summary>
        /// Wrapper for /offices/{officeId}
        ///
        /// https://forecast-v3.weather.gov/documentation
        /// </summary>
        /// <param name="officeId">Office identifier to get data for</param>
        /// <returns>Information about the office specified</returns>
        /// <exception cref="NotImplementedException"></exception>
        public NwsOffice OfficeData(string officeId)
        {
            throw new NotImplementedException(nameof(OfficeData) + " not implemented");
        }


        // TODO: Wrapper for /zones/{type}/{zoneId}

        // TODO: Wrapper for /zones/{type}/{zoneId}/forecast


        // TODO: Wrapper for /alerts?{parameters}

        // TODO: Wrapper for /alerts/active

        // TODO: Wrapper for /alerts/{alertId}

        // TODO: Wrapper for /alerts/active/count

        // TODO: Wrapper for /alerts/active/zone/{zoneId}

        // TODO: Wrapper for /alerts/active/area/{area}

        // TODO: Wrapper for /alerts/active/region/{region}

        #endregion

    }
}
