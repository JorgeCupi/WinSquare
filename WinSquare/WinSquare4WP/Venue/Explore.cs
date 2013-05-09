using QuickMethods;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WinSquare.Classes;
using WinSquare.Credentials;
using Newtonsoft.Json;

namespace WinSquare
{
    namespace VenueMethods
    {
        public partial class Venues
        {
            #region Userless

            #region Explore using Latitude and Longitude
            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingLatitudeAndLongitude(DateTime date, double latitude,double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude,string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingLatitudeAndLongitude(DateTime date,double latitude,double longitude,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingLatitudeAndLongitude(DateTime date,double latitude,double longitude,string query,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }
            #endregion

            #region Explore using Near (near a place)
            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingNear(DateTime date,string place)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingNear(DateTime date, string place,string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&query=" + query +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingNear(DateTime date, string place,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&limit=" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessExploreUsingNear(DateTime date, string place,string query,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&query=" + query +
                    "&limit" + limit +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }
            #endregion

            #endregion

            #region Authenticated

            #region Search using Latitude and Longitude
            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingLatitudeAndLongitude(DateTime date, double latitude,double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingLatitudeAndLongitude(DateTime date,double latitude,double longitude,string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingLatitudeAndLongitude(DateTime date, double latitude,double longitude,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingLatitudeAndLongitude(DateTime date,double latitude,double longitude,string query,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <param name="novelty">Pass NEW or OLD to limit results to places the user hasn't been or has been, respectively</param>
            /// <param name="friendsVisited">Pass VISITED or NOTVISITED to limit results to places the acting user's friends have or haven't been, respectively</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingLatitudeAndLongitude(DateTime date,double latitude,double longitude,string query,int limit,string novelty,string friendsVisited)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&novelty=" + novelty +
                    "&friendVisits=" + friendsVisited +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }
            #endregion

            #region Search using Near (near a place)
            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingNear(DateTime date,string place)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingNear(DateTime date,string place, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&query=" + query +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingNear(DateTime date,string place,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingNear(DateTime date, string place,string query,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&query=" + query +
                    "&limit" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }

            /// <summary>
            /// Explore method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <param name="novelty">Pass NEW or OLD to limit results to places the user hasn't been or has been, respectively</param>
            /// <param name="friendsVisited">Pass VISITED or NOTVISITED to limit results to places the acting user's friends have or haven't been, respectively</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedExploreUsingNear(DateTime date,string place,string query,int limit,string novelty,string friendsVisited)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlExplore +
                    "near=" + place +
                    "&query=" + query +
                    "&limit" + limit +
                    "&novelty" + novelty+
                    "&friendVisits" + friendsVisited +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonExploreString(response);
            }
            #endregion

            #endregion
        }
    }
}
