using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ExploreGroup
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("items")]
        public List<ExploreItem> items { get; set; }
    }
}
