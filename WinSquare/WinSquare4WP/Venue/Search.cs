using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using WinSquare.Credentials;
using QuickMethods;
using WinSquare.Classes;
using Newtonsoft.Json;
using System.Windows;
namespace WinSquare
{
    namespace VenueMethods
    {
        public partial class Venues
        {
            #region Userless
            #region Search using Latitude and Longitude
           /// <summary>
           /// Search method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
           /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
           /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
           /// </summary>
           /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
           /// <param name="latitude">A double number, for example: 15.68</param>
           /// <param name="longitude">A double number, for example: -32.15</param>
           /// <returns>A json String</returns>
            public static async Task<List<Venue>> UserlessSearchUsingLatitudeAndLongitude(DateTime date, double latitude,  double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch+
                    "ll=" + latitude + "," + longitude +
                    "&client_id=" + AppDetails.clientID+
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                
                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingLatitudeAndLongitude(DateTime date, 
                                                    double latitude, double longitude, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&query="+query+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret, that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>>UserlessSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int limit)
            {
                
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&limit="+limit+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&query="+query+
                    "&limit="+limit+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="categories">A List of strings that represent Categories ID's</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, List<string>categories)
            {
                string ID="";
                foreach (string S in categories)
                    ID+=S+",";
                
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&categoryId="+ID+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }
            #endregion

            #region Search using Near (near a place)
            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingNear(DateTime date, string place)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near="+place +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingNear(DateTime date,string place,string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&query="+query+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingNear(DateTime date,string place,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&limit="+limit+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingNear(DateTime date,string place,string query,int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&query="+query+
                    "&limit"+limit+
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses clientID and clientSecret that should be provided before. Doesn't need authentication
            /// You should set clientID and clientSecret using one of the SetCredentials methods from the Login class in Authenticate namespace
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="categories">A List of strings that represent Categories ID's</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> UserlessSearchUsingNear(DateTime date, string place, List<string> categories)
            {
                string ID = "";
                foreach (string S in categories)
                    ID += S + ",";
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&categoryId=" + ID +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                string response =await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }
            #endregion
            #endregion

            #region Authenticated
            #region Search using Latitude and Longitude
            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);
                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, string query, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&query=" + query +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="latitude">A double number, for example: 15.68</param>
            /// <param name="longitude">A double number, for example: -32.15</param>
            /// <param name="categories">A List of strings that represent Categories ID's</param>
            /// <returns>A json String</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingLatitudeAndLongitude(DateTime date, double latitude, double longitude, List<string> categories)
            {
                string ID = "";
                foreach (string S in categories)
                    ID += S + ",";
                
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "ll=" + latitude + "," + longitude +
                    "&categoryId=" + ID +
                    "&client_id=" + AppDetails.clientID +
                    "&client_secret=" + AppDetails.clientSecret +
                    "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }
            #endregion

            #region Search using Near (near a place)
            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingNear(DateTime date, string place)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingNear(DateTime date, string place, string query)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&query=" + query +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingNear(DateTime date, string place, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&limit=" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="query">For example: Donuts or something similar that will refine the search.</param>
            /// <param name="limit">The max number of results that you want in your result. Example: 23</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingNear(DateTime date, string place, string query, int limit)
            {
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&query=" + query +
                    "&limit" + limit +
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }

            /// <summary>
            /// Search method that uses an accessToken, that should be provided before.This method does need authentication.
            /// You will automatically get an accessToken using the Authenticate method from the Login class in Authenticate namespace.
            /// For a difference between Search and Explore, take a look at the Foursquare's API documentation.
            /// </summary>
            /// <param name="date">A DateTime, recommended to use DateTime.Now() for fresh results</param>
            /// <param name="place">Should be a geocodable string. For example: Chicago, IL.</param>
            /// <param name="categories">A List of strings that represent Categories ID's</param>
            /// <returns>A json string</returns>
            public static async Task<List<Venue>> AuthenticatedSearchUsingNear(DateTime date, string place, List<string> categories)
            {
                string ID = "";
                foreach (string S in categories)
                    ID += S + ",";
                
                client = new WebClient();
                Uri formatedUri = new Uri(urlSearch +
                    "near=" + place +
                    "&categoryId="+ID+
                    "&oauth_token=" + AppDetails.accessToken +
                   "&v=" + date.Year + date.Month.ToString("d2") + date.Day.ToString("d2"), UriKind.Absolute);

                string response = await Internet.DownloadStringAsync(client, formatedUri);
                return GetListFromJsonString(response);
            }
            #endregion
            #endregion
        }
    }
}
