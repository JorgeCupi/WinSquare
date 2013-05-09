using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Statistics
    {
        [JsonProperty("checkinsCount")]
        public int checkinsCount { get; set; }
        [JsonProperty("usersCount")]
        public int usersCount { get; set; }
        [JsonProperty("tipCount")]
        public int tipCount { get; set; }
    }
}