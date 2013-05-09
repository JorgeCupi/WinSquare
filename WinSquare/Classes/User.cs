using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class User
    {
        [JsonProperty("id")]
        public string id{ get; set; }

        [JsonProperty("firstName")]
        public string firstName{ get; set; }

        [JsonProperty("lastName")]
        public string lastName { get; set; }

        [JsonProperty("gender")]
        public string gender { get; set; }

        [JsonProperty("photo")]
        public Photo photo { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }
        
    }
}
