using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ExploreItem
    {
        [JsonProperty("reasons")]
        public Reasons reasons{ get; set; }
        [JsonProperty("venue")]
        public Venue venue{ get; set; }
        [JsonProperty("tips")]
        public List<Tip> tips{ get; set; }
        [JsonProperty("phrases")]
        public List<Phrases> phrases { get; set; }
        [JsonProperty("referralID")]
        public string referralID { get; set; }
    }
}
