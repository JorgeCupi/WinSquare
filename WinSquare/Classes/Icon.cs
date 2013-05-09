using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class Icon
    {
        [JsonProperty("prefix")]
        public string prefix { get; set; }
        [JsonProperty("suffix")]
        public string suffix { get; set; }
        public string logo { get; set; }
        public string getLogo()
        {
            logo = prefix.Substring(0, prefix.Length)+"64"+ suffix;
            return logo;
        }
    }
}