using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class ListItem
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("items")]
        public List<ListedItems> items { get; set; }
    }
}
