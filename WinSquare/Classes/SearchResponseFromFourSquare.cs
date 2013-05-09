using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class SearchResponseFromFourSquare
    {
        [JsonProperty("meta")]
        public Meta meta { get; set; }
        [JsonProperty("notifications")]
        public List<Notification> notifications { get; set; }
        [JsonProperty("response")]
        public SearchResponse response { get; set; }
    }
}
