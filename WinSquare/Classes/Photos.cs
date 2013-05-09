using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class Photos
    {
        [JsonProperty("count")]
        public int count{ get; set; }
        [JsonProperty("groups")]
        public List<PhotoGroup>groups{ get; set; }
    }
}
