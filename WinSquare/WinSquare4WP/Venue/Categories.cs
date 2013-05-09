using Newtonsoft.Json;
using QuickMethods;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WinSquare.Classes;
using WinSquare.Credentials;

namespace WinSquare
{
    namespace VenueMethods
    {
        public partial class Venues
        {
            /// <summary>
            /// Method that uses clientID and clientSecret (that should be provided before) to get a list of Foursquare's categories. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <returns>A list of Categories</returns>
            public static async Task<List<Category>> UserlessGetCategories(DateTime date)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlCategories +
                    "client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetCategoriesList(response);
            }

            /// <summary>
            /// Method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <returns>A list of Categories</returns>
            public static async Task<List<Category>> AuthenticatedGetCategories(DateTime date)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlCategories +
                    "oauth_token=" + AppDetails.accessToken+
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetCategoriesList(response);
            }
        }
    }
}
