using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class SearchResponse
    {
        [JsonProperty("venues")]
        public List<Venue> venues{ get; set; }
    }
}
