using System;
using System.Reflection.Metadata;
using Newtonsoft.Json;

namespace NwsApi.Models
{
    public class NwsPoint
    {
        /// <summary>
        /// Same identifier as the Forecast Office identifier
        /// </summary>
        /// <see href="https://w1.weather.gov/glossary/index.php?word=CWA"/>
        [JsonProperty("cwa")]
        public string CountyWarningArea { get; set; }

        [JsonProperty]
        public Uri ForecastOffice { get; set; }

        [JsonProperty]
        public int GridX { get; set; }

        [JsonProperty]
        public int GridY { get; set; }

        [JsonProperty]
        public Uri Forecast { get; set; }

        [JsonProperty]
        public Uri ForecastHourly { get; set; }

        [JsonProperty]
        public Uri ForecastGridData { get; set; }

        [JsonProperty]
        public Uri ObservationStations { get; set; }

        [JsonProperty]
        public RelativeLocation RelativeLocation { get; set; }

        [JsonProperty]
        public Uri ForecastZone { get; set; }

        [JsonProperty]
        public Uri County { get; set; }

        [JsonProperty]
        public Uri FireWeatherZone { get; set; }

        [JsonProperty]
        public string TimeZone { get; set; }

        [JsonProperty]
        public string RadarStation { get; set; }
    }
}
