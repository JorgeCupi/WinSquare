using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Keyword
    {
        [JsonProperty("displayName")]
        public string displayName{ get; set; }
        [JsonProperty("keyword")]
        public string keyword { get; set; }
    }
}
