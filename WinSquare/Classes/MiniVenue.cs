using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class MiniVenue
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty ("contact")]
        public Contact contact{ get; set; }
        [JsonProperty("location")]
        public Location location { get; set; }
        [JsonProperty("categories")]
        public List<Category> categories { get; set; }

        public Category firstCategory { get; set; }
    }
}