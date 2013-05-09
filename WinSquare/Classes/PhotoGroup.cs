using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class PhotoGroup
    {
        [JsonProperty("type")]
        public string type{ get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("count")]
        public int count{ get; set; }
        [JsonProperty("items")]
        public List<Photo> items{ get; set; }
    }
}
