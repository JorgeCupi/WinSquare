using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Price
    {
        [JsonProperty("tier")]
        public int tier { get; set; }

        [JsonProperty("message")]
        public string message{ get; set; }
    }
}
