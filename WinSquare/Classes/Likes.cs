using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Likes
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("groups")]
        public List<Group> groups { get; set; }
        [JsonProperty("summary")]
        public string summary{ get; set; }
    }
}
