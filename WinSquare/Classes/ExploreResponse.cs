using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ExploreResponse
    {
        [JsonProperty("keywords")]
        public Keywords keywords { get; set; }

        [JsonProperty("suggestedRadius")]
        public int suggestedRadius{ get; set; }
        
        [JsonProperty("headerLocation")]
        public string headerLocation { get; set; }

        [JsonProperty("headerFullLocation")]
        public string headerFullLocation { get; set; }

        [JsonProperty("headerLocationGranularity")]
        public string headerLocationGranularity { get; set; }

        [JsonProperty("headerMessage")]
        public string headerMessage { get; set; }
        
        [JsonProperty("totalResults")]
        public int totalResults{ get; set; }

        [JsonProperty("groups")]
        public List<ExploreGroup> groups { get; set; }
    }
}
