using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Reasons
    {
        [JsonProperty("count")]
        public int count{ get; set; }
        [JsonProperty("items")]
        public List<ReasonItems> items { get; set; }
    }
}
