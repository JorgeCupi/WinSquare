using Newtonsoft.Json;
using System.Text;

namespace WinSquare.Classes
{
    public class NamedSegment
    {
        [JsonProperty("label")]
        public string label { get; set; }
        [JsonProperty("start")]
        public string start { get; set; }
        [JsonProperty("end")]
        public string end { get; set; }
        [JsonProperty("renderedTime")]
        public string renderedTime { get; set; }
    }
}
