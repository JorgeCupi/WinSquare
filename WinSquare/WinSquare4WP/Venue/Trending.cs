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
            #region Userless Trending using Latitude and Longitude
            /// <summary>
            /// Trending method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<List<Venue>> UserlessTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Trending method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="radius">Radius in meters, up to approximately 2000 meters.</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<List<Venue>> UserlessTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int radius)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&radius=" + radius +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Trending method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<List<Venue>> UserlessTrendingUsingLatitudeAndLongitude(DateTime date, int limit, double latitude, double longitude)
            {

                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Trending method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="radius">Radius in meters, up to approximately 2000 meters.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<List<Venue>> UserlessTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int radius, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&radius=" + radius +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }
            #endregion

            #region Authenticated Trending using Latitude and Longitude
            /// <summary>
            /// Trending method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<string> AuthenticatedTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// Trending method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="radius">Radius in meters, up to approximately 2000 meters.</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<string> AuthenticatedTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int radius)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&radius=" + radius +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// Trending method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<string> AuthenticatedTrendingUsingLatitudeAndLongitude(DateTime date, int limit, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }

            /// <summary>
            /// Trending method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="radius">Radius in meters, up to approximately 2000 meters.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A list of the most popular venues</returns>
            public static async Task<string> AuthenticatedTrendingUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int radius, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlTrending +
                    "ll=" + latitude + "," + longitude +
                    "&radius=" + radius +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                return await Internet.DownloadStringAsync(client, formatedUri);
            }
            #endregion
        }
    }
}
