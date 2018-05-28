using Newtonsoft.Json;

namespace NwsApi.Models
{
    public class RelativeLocation
    {
        [JsonProperty]
        public string City { get; set; }

        /// <summary>
        /// Two-letter state Code
        /// </summary>
        [JsonProperty]
        public string State { get; set; }

        // This type doesn't seem to be populated in responses at the moment
        //public TYPE Geometry { get; set; }

        [JsonProperty]
        public QuantitativeValue Distance { get; set; }

        [JsonProperty]
        public QuantitativeValue Bearing { get; set; }
    }
}
