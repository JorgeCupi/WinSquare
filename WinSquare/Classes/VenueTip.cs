using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class VenueTip
    {
        [JsonProperty("count")]
        public int count { get; set; }
        [JsonProperty("groups")]
        public List<VenueTipGroup> groups{ get; set; }
    }
}
