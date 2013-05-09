using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class Menu
    {
        [JsonProperty("type")]
        public string type{ get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("mobileUrl")]
        public string mobileUrl { get; set; }
    }
}
