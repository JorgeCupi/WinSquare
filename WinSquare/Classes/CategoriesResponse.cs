using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WinSquare.Classes
{
    public class CategoriesResponse
    {
        [JsonProperty("categories")]
        public List<Category> categories{ get; set; }
    }
}
