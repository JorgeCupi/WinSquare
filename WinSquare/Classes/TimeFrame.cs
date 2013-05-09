using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class TimeFrame
    {
        [JsonProperty("days")]
        public string days { get; set; }
        [JsonProperty("includesToday")]
        public bool includesToday { get; set; }
        [JsonProperty("open")]
        public List<NamedSegment> open { get; set; }
        [JsonProperty("segments")]
        public List<TimeSegment> segments { get; set; }
    }
}