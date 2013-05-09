using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class PageUpdate
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("items")]
        public List<Item> items { get; set; }
    }
}
