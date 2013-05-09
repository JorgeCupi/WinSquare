using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Entity
    {
        [JsonProperty("indices")]
        public List<int> indices{ get; set; }
        [JsonProperty("type")]
        public string type{ get; set; }
        
    }
}
