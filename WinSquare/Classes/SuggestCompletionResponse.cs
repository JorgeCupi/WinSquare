using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace WinSquare.Classes
{
    public class SuggestCompletionResponse
    {
        [JsonProperty("minivenues")]
        public List<MiniVenue> venues { get; set; }
    }
}
