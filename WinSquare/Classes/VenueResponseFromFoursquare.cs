using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WinSquare.Classes
{
    public class VenueResponseFromFoursquare
    {
        [JsonProperty("meta")]
        public Meta meta{ get; set; }
        [JsonProperty("notifications")]
        public List<Notification> notifications { get; set; }
        [JsonProperty("response")]
        public VenueResponse response { get; set; }
    }
}
