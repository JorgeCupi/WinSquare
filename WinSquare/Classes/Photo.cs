using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Photo
    {
        [JsonProperty("id")]
        public string id{ get; set; }
        [JsonProperty("createdAt")]
        public int createdAt { get; set; }
        [JsonProperty ("source")]
        public Source source{ get; set; }
        [JsonProperty("prefix")]
        public string prefix { get; set; }
        [JsonProperty("suffix")]
        public string suffix{ get; set; }
        [JsonProperty("width")]
        public int width { get; set; }
        [JsonProperty("height")]
        public int height{ get; set; }
        [JsonProperty("user")]
        public User user { get; set; }
        [JsonProperty("visibility")]
        public string visibility { get; set; }


    }
}
