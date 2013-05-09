using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class SpecialItem
    {
        [JsonProperty("id")]
        public string id{ get; set; }

        [JsonProperty("frequency")]
        public string frequency{ get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("imageUrls")]
        public ImageUrls imageUrls{ get; set; }

        [JsonProperty("description")]
        public string description{ get; set; }

        [JsonProperty("finePrint")]
        public string finePrint { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("provider")]
        public string provider { get; set; }

        [JsonProperty("redemption")]
        public string redemption { get; set; }

        [JsonProperty("page")]
        public Page page { get; set; }

        [JsonProperty("likes")]
        public Likes likes { get; set; }
        
    }
}