using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class CategoriesResponseFromFoursquare
    {
        [JsonProperty("meta")]
        public Meta meta { get; set; }
        [JsonProperty("notifications")]
        public List<Notification> notifications { get; set; }
        [JsonProperty("response")]
        public CategoriesResponse response { get; set; }
    }
}
