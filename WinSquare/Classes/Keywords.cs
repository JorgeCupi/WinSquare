using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Keywords
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("items")]
        public List<Keyword> items { get; set; }
    }
}