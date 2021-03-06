﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ExploreResponseFromFoursquare
    {
        [JsonProperty("meta")]
        public Meta meta { get; set; }
        [JsonProperty("notifications")]
        public List<Notification> notifications { get; set; }
        [JsonProperty("response")]
        public ExploreResponse response { get; set; }
        [JsonProperty("numResults")]
        public int numResults{ get; set; }
    }
}
