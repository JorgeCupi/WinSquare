using Newtonsoft.Json;
using System;

namespace WinSquare.Classes
{
    public class Source
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("url")]
        public string url{ get; set; }
    }
}
