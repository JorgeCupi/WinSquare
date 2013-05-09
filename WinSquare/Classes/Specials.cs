using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Specials
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("items")]
        public List<SpecialItem> items { get; set; }
    }
}