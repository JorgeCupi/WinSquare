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
            #region Userless SuggestCompletion using Latitude and Longitude
            /// <summary>
            /// SuggestCompletion method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A json String</returns>
            public static async Task<List<MiniVenue>> UserlessSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonMiniString(response);
            }

            /// <summary>
            /// SuggestCompletion method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the SuggestCompletion.</param>
            /// <returns>A json string</returns>
            public static async Task<List<MiniVenue>> UserlessSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonMiniString(response);
            }

            /// <summary>
            /// SuggestCompletion method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<MiniVenue>> UserlessSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int limit)
            {

                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonMiniString(response);
            }

            /// <summary>
            /// SuggestCompletion method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the SuggestCompletion.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<MiniVenue>> UserlessSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonMiniString(response);
            }
            #endregion

            #region SuggestCompletion using Latitude and Longitude
            /// <summary>
            /// SuggestCompletion method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A json String</returns>
            public static async Task<string> AuthenticatedSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// SuggestCompletion method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the SuggestCompletion.</param>
            /// <returns>A json String</returns>
            public static async Task<string> AuthenticatedSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// SuggestCompletion method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<string> AuthenticatedSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// SuggestCompletion method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the SuggestCompletion.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<string> AuthenticatedSuggestCompletionUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSuggestCompletion +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }
            #endregion
        }
    }
}
