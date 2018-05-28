using System;
using Newtonsoft.Json;

namespace NwsApi.Models
{
    public class NwsPoint
    {
        [JsonProperty]
        public Uri ForecastOffice { get; set; }
        
        [JsonProperty]
        public Uri Forecast { get; set; }

        [JsonProperty]
        public Uri ForecastHourly { get; set; }

        [JsonProperty]
        public Uri ForecastGridData { get; set; }

        [JsonProperty]
        public Uri ObservationStations { get; set; }

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
