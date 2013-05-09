using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class ListedVenueItem
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("user")]
        public User user { get; set; }
        [JsonProperty("editable")]
        public bool editable { get; set; }
        [JsonProperty("public")]
        public bool isPublic { get; set; }
        [JsonProperty("collaborative")]
        public bool collaborative { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("canonicalUrl")]
        public string canonicalUrl { get; set; }
        [JsonProperty("createdAt")]
        public int createdAt { get; set; }
        [JsonProperty("updatedAt")]
        public int updatedAt { get; set; }
        [JsonProperty("photo")]
        public Photo photo { get; set; }
        [JsonProperty("followers")]
        public Follower followers{ get; set; }
        [JsonProperty("listItems")]
        public ListItem listItems { get; set; }
    }
}
