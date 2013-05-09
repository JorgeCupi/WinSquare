using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinSquare.Classes
{
    public class Phrases
    {
        [JsonProperty("phrase")]
        public string phrase { get; set; }
        [JsonProperty("sample")]
        public Sample sample { get; set; }
        [JsonProperty("count")]
        public int count { get; set; }
        
    }
}
