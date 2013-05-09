using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Follower
    {
        [JsonProperty("count")]
        public int count { get; set; }
    }
}
