using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class Page
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("firstName")]
        public string firstName { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("photo")]
        public Photo photo { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("tips")]
        public Tip tips{ get; set; }

        [JsonProperty("homeCity")]
        public string homeCity { get; set; }

        [JsonProperty("bio")]
        public string bio { get; set; }

        [JsonProperty("contact")]
        public Contact contact{ get; set; }

    }
}
