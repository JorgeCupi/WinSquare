using System;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Item
    {
        [JsonProperty("unreadCount")]
        public int unreadCount { get; set; }
    }
}