using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ImageUrls
    {
        [JsonProperty("count")]
        public int count{ get; set; }
    }
}
