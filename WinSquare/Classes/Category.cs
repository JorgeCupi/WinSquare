using System;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace WinSquare.Classes
{
    public class Category
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("pluralName")]
        public string pluralName { get; set; }
        [JsonProperty("shortName")]
        public string shortName { get; set; }
        [JsonProperty("icon")]
        public Icon icon { get; set; }
        [JsonProperty("primary")]
        public bool primary { get; set; }
        [JsonProperty("categories")]
        public List<Category> categories{ get; set; }


    }
}
