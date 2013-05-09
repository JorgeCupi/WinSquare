using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Hours
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("isOpen")]
        public bool isOpen { get; set; }
        [JsonProperty("timeframes")]
        public List<TimeFrame> timeframes { get; set; }

        [JsonProperty("days")]
        public List<int> days{ get; set; }
        [JsonProperty("open")]
        public List<TimeSegment> open{ get; set; }
        [JsonProperty("includesToday")]
        public bool includesToday { get; set; }
        [JsonProperty("segments")]
        public List<NamedSegment> segments{ get; set; }
    }
}
