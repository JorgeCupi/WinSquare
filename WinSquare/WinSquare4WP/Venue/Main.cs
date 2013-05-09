using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WinSquare.Classes;
using QuickMethods;
using WinSquare.Credentials;
namespace WinSquare
{
    namespace VenueMethods
    {
        /// <summary>
        /// Venues class contains a series of methods to help you search, explore, add venues, etc, using different types of queries.
        /// </summary>
        public partial class Venues
        {
            private static string urlSearch = "https://api.foursquare.com/v2/venues/search?";
            private static string urlExplore = "https://api.foursquare.com/v2/venues/explore?";
            private static string urlCategories = "https://api.foursquare.com/v2/venues/categories?";
            private static string urlTrending = "https://api.foursquare.com/v2/venues/trending?";
            private static string urlSuggestCompletion = "https://api.foursquare.com/v2/venues/suggestcompletion?";
            private static string urlVenue = "https://api.foursquare.com/v2/venues/";
            private static WebClient client;

            /// <summary>
            /// Method that gets a Venue using it's ID
            /// <para>Since the Search and Explore methods from Foursquare now return only a Mini Venue,</para>
            /// <para>this method comes pretty handy to obtain full information about a Venue that the user</para>
            /// <para>may select from a list.</para>
            /// </summary>
            /// <param name="idVenue"></param>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <returns>A complete Venue object</returns>
            public static async Task<Venue> GetVenue(string idVenue,DateTime date)
            {
                client = new WebClient();
                Uri uri = new Uri(urlVenue + idVenue +
                    "?client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                string jsonString = await Internet.DownloadStringAsync(client, uri);
                VenueResponseFromFoursquare response = JsonConvert.DeserializeObject<VenueResponseFromFoursquare>(jsonString);
                Venue venue = response.response.venue;

                if (venue.categories.Count > 0)
                {
                    venue.firstCategory = venue.categories[0];
                    venue.firstCategory.icon.logo = venue.firstCategory.icon.getLogo();
                }
                return venue;
            }

            private static List<Venue> GetListFromJsonExploreString(string jsonString)
            {
                ExploreResponseFromFoursquare response = JsonConvert.DeserializeObject<ExploreResponseFromFoursquare>(jsonString);
                List<Venue> lstVenues = new List<Venue>();

                foreach (ExploreItem item in response.response.groups[0].items)
                    lstVenues.Add(item.venue);

                foreach (Venue item in lstVenues)
                {
                    if (item.categories.Count > 0)
                    {
                        item.firstCategory = item.categories[0];
                        item.firstCategory.icon.logo = item.firstCategory.icon.getLogo();
                    }
                }
                return lstVenues;
            }

            private static List<Venue> GetListFromJsonString(string jsonString)
            {
                SearchResponseFromFourSquare response = JsonConvert.DeserializeObject<SearchResponseFromFourSquare>(jsonString);

                List<Venue> lstVenues = response.response.venues;
                foreach (Venue item in lstVenues)
                {
                    if (item.categories.Count > 0)
                    {
                        item.firstCategory = item.categories[0];
                        item.firstCategory.icon.logo = item.firstCategory.icon.getLogo();
                    }
                }
                return lstVenues;
            }

            private static List<MiniVenue> GetListFromJsonMiniString(string jsonString)
            {
                SuggestCompletionResponseFromFoursquare response = JsonConvert.DeserializeObject<SuggestCompletionResponseFromFoursquare>(jsonString);

                List<MiniVenue> lstVenues = response.response.venues;
                foreach (MiniVenue item in lstVenues)
                {
                    if (item.categories.Count > 0)
                    {
                        item.firstCategory = item.categories[0];
                        item.firstCategory.icon.logo = item.firstCategory.icon.getLogo();
                    }
                }
                return lstVenues;
            }
            
            private static List<Category> GetCategoriesList(string jsonString)
            {
                CategoriesResponseFromFoursquare response = JsonConvert.DeserializeObject<CategoriesResponseFromFoursquare>(jsonString);
                return response.response.categories;
            }
        }
    }
}
