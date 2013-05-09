using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Notification
    {
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("item")]
        public Item item { get; set; }
    }
}
