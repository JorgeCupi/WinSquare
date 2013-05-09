using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Flag
    {
        [JsonProperty("outsideRadius")]
        public bool outsideRadius { get; set; }
        [JsonProperty("exactMatch")]
        public bool exactMatch{ get; set; }
    }
}
