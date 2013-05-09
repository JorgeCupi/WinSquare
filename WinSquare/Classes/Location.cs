using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Location
    {
        [JsonProperty("address")]
        public string address { get; set; }
        [JsonProperty("crossStreet")]
        public string crossStreet{ get; set; }
        [JsonProperty("lat")]
        public string lat { get; set; }
        [JsonProperty("lng")]
        public string lng { get; set; }
        [JsonProperty("distance")]
        public string distance { get; set; }
        [JsonProperty("postalCode")]
        public string postalColde { get; set; }
        [JsonProperty("city")]
        public string city { get; set; }
        [JsonProperty("state")]
        public string state { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("cc")]
        public string cc { get; set; }
    }
}
