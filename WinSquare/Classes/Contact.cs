using System;
using System.Windows;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Contact
    {
        [JsonProperty("twitter")]
        public string twitter { get; set; }
        [JsonProperty("facebook")]
        public string facebook { get; set; }
        [JsonProperty("phone")]
        public string phone { get; set; }
        [JsonProperty("formattedPhone")]
        public string formattedPhone { get; set; }
    }
}
