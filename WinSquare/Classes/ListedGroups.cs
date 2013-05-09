using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class ListedGroups
    {
        [JsonProperty("type")]
        public string type{ get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("count")]
        public int count{ get; set; }
        [JsonProperty("items")]
        public List<ListedVenueItem> items { get; set; }
        
    }
}
