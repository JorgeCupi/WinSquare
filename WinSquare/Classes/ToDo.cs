using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ToDo
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("groups")]
        public List<Group> groups { get; set; }
    }
}
