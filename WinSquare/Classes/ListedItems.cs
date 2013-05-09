using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class ListedItems
    {
        [JsonProperty("id")]
        public string id{ get; set; }

        [JsonProperty("createdAt")]
        public int createdAt{ get; set; }

        [JsonProperty("tip")]
        public Tip tip { get; set; }

        [JsonProperty("photo")]
        public Photo photo{ get; set; }
    }
}
