using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Newtonsoft.Json;
namespace WinSquare.Classes
{
    public class Venue
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("contact")]
        public Contact contact { get; set; }
        [JsonProperty("location")]
        public Location location { get; set; }
        [JsonProperty("categories")]
        public List<Category> categories { get; set; }
        [JsonProperty("verified")]
        public bool verified { get; set; }
        [JsonProperty("restricted")]
        public bool restricted { get; set; }
        [JsonProperty("stats")]
        public Statistics stats { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("hours")]
        public Hours hours{ get; set; }
        [JsonProperty("popular")]
        public Hours popular{ get; set; }
        [JsonProperty("menu")]
        public Menu menu { get; set; }
        [JsonProperty("price")]
        public Price price { get; set; }
        [JsonProperty("specials")]
        public Specials specials { get; set; }
        [JsonProperty("hereNow")]
        public HereNow hereNow { get; set; }
        [JsonProperty("reasons")]
        public Reasons reasons{ get; set; }
        [JsonProperty("description")]
        public string description { get; set; }
        [JsonProperty("createdAt")]
        public int createdAt{ get; set; }
        [JsonProperty("mayor")]
        public Mayor mayor { get; set; }
        [JsonProperty("tips")]
        public VenueTip tips{ get; set; }
        [JsonProperty("tags")]
        public List<string> tags{ get; set; }
        [JsonProperty("beenHere")]
        public int beenHere{ get; set; }
        [JsonProperty("shortUrl")]
        public string shortUrl { get; set; }
        [JsonProperty("canonicalUrl")]
        public string canonicalUrl{ get; set; }
        [JsonProperty("timeZone")]
        public string timeZone { get; set; }
        [JsonProperty("listed")]
        public Listed listed{ get; set; }
        [JsonProperty("phrases")]
        public List<Phrases> phrases { get; set; }
        [JsonProperty("specialsNearby")]
        public List<Specials> specialsNearby{ get; set; }
        [JsonProperty("photos")]
        public Photos photos { get; set; }
        [JsonProperty("likes")]
        public Likes likes { get; set; }
        [JsonProperty("like")]
        public bool like { get; set; }
        [JsonProperty("dislike")]
        public bool dislike { get; set; }
        [JsonProperty("rating")]
        public string rating{ get; set; }
        [JsonProperty("roles")]
        public List<string> roles{ get; set; }
        [JsonProperty("flags")]
        public Flag flags{ get; set; }
        [JsonProperty("pageUpdates")]
        public PageUpdate pageUpdate{ get; set; }

        public Category firstCategory { get; set; }
    }
}