using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Sample
    {
        [JsonProperty("entities")]
        public List<Entity> entities { get; set; }
        [JsonProperty("text")]
        public string text { get; set; }
        
    }
}
