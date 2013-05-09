using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class HereNow
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("summary")]
        public string summary{ get; set; }
        [JsonProperty("groups")]
        public List<Group> groups { get; set; }
    }
}