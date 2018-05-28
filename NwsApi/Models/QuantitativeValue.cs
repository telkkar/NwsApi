using Newtonsoft.Json;

namespace NwsApi.Models
{
    public class QuantitativeValue
    {
        [JsonProperty]
        public double Value { get; set; }

        [JsonProperty]
        public string UnitCode { get; set; }
    }
}
