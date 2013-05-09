using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class TimeSegment
    {
        [JsonProperty("start")]
        public string start { get; set; }
        [JsonProperty("end")]
        public string end { get; set; }
    }
}
