using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Tip
    {
        [JsonProperty("id")]
        public string id{ get; set; }
        [JsonProperty("createdAt")]
        public int createdAt { get; set; }
        [JsonProperty("text")]
        public string text{ get; set; }
        [JsonProperty("canonicalUrl")]
        public string canonicalUrl { get; set; }
        [JsonProperty("logView")]
        public bool logView { get; set; }
        [JsonProperty("likes")]
        public Likes likes { get; set; }
        [JsonProperty("like")]
        public bool like { get; set; }
        [JsonProperty("todo")]
        public ToDo ToDo{ get; set; }
        [JsonProperty("user")]
        public User user{ get; set; }

        [JsonProperty("count")]
        public int count{ get; set; }
    }
}
