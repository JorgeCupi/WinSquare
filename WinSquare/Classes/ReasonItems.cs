using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class ReasonItems
    {
        [JsonProperty("summary")]
        public string summary{ get; set; }
        [JsonProperty("type")]
        public string type{ get; set; }
        [JsonProperty("reasonName")]
        public string reasonName{ get; set; }
    }
}
