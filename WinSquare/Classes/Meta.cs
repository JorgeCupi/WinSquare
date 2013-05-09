using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Meta
    {
        [JsonProperty("code")]
        public string code { get; set; }
        [JsonProperty("errorType")]
        public string errorType { get; set; }
        [JsonProperty("errorDetail")]
        public string errorDetail { get; set; }
    }
}
