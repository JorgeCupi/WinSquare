using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Group
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("items")]
        public List<User> items { get; set; }
    }
}