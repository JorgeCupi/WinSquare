using Newtonsoft.Json;
using System;

namespace WinSquare.Classes
{
    public class VenueResponse
    {
        [JsonProperty("venue")]
        public Venue venue { get; set; }
    }
}
