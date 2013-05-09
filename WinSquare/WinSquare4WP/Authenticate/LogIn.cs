using System;
using System.Windows;

using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;
using WinSquare.Credentials;

namespace WinSquare
{
    namespace Authenticate
    {
        /// <summary>
        /// This class has helpful methods to set your Application's clientSecret, clientID among others.
        /// All this data should be use from AppDetails class located in the Credentials namespace
        /// </summary>
        public class LogIn
        {
            /// <summary>
            /// Recommended method to set the AppDetails.clientID
            /// </summary>
            /// <param name="clientID">Your Foursquare application's clientID</param>
            public static void SetCredentials(string clientID)
            {
                AppDetails.clientID = clientID;
            }

            /// <summary>
            /// Recommended method to set the both clientID and clientSecret atributes in AppDetails class
            /// </summary>
            /// <param name="clientID">Your Foursquare application's clientID</param>
            /// <param name="clientSecret">Your Foursquare application's clientSecret</param>
            public static void SetCredentials(string clientID, string clientSecret)
            {
                AppDetails.clientID = clientID;
                AppDetails.clientSecret = clientSecret;
            }

            /// <summary>
            /// Recommended method to set the both clientID and clientSecret atributes in AppDetails class, plus your application's home website registered
            /// </summary>
            /// <param name="clientID">Your Foursquare application's clientID</param>
            /// <param name="clientSecret">Your Foursquare application's clientSecret</param>
            /// <param name="homePage">Your registered homepage url on Foursquare's website</param>
            public static void SetCredentials(string clientID, string clientSecret, string homePage)
            {
                AppDetails.clientID = clientID;
                AppDetails.clientSecret = clientSecret;
                AppDetails.urlHomePage = homePage;
            }

            /// <summary>
            /// Recommended method to set the both clientID and clientSecret atributes in AppDetails class, plus your application's home website registered
            /// </summary>
            /// <param name="clientID">Your Foursquare application's clientID</param>
            /// <param name="clientSecret">Your Foursquare application's clientSecret</param>
            /// <param name="homePage">Your registered homepage url on Foursquare's website</param>
            /// <param name="privacyPage">Your registered privacyPage url on Foursquare's website</param>
            public static void SetCredentials(string clientID, string clientSecret, string homePage, string privacyPage)
            {
                AppDetails.clientID = clientID;
                AppDetails.clientSecret = clientSecret;
                AppDetails.urlHomePage = homePage;
                AppDetails.urlPrivacyPage = privacyPage;
            }

            /// <summary>
            /// Recommended method to set the both clientID and clientSecret atributes in AppDetails class, plus your application's home website registered
            /// </summary>
            /// <param name="clientID">Your Foursquare application's clientID</param>
            /// <param name="clientSecret">Your Foursquare application's clientSecret</param>
            /// <param name="homePage">Your registered homepage url on Foursquare's website</param>
            /// <param name="privacyPage">Your registered privacyPage url on Foursquare's website</param>
            /// <param name="callbackPage">Your registered callbackPage url on Foursquare's website</param>
            public static void SetCredentials(string clientID, string clientSecret, string homePage, string privacyPage, string callbackPage)
            {
                AppDetails.clientID = clientID;
                AppDetails.clientSecret = clientSecret;
                AppDetails.urlHomePage = homePage;
                AppDetails.urlPrivacyPage = privacyPage;
                AppDetails.urlCallBackPage = callbackPage;
            }

            /// <summary>
            /// Method to use when you want your user to authenticate in order to get an AccessToken, 
            /// after calling this method you should use the GetAccesToken method to retrieve your user's accessToken and store it
            /// so you don't have to call this method everytime
            /// </summary>
            /// <param name="browser">Put the webBrowser control you want your user to use in order to log into Foursquare to get their accessToken</param>
            public static void Authenticate(WebBrowser browser)
            {
                browser.Navigated += browser_Navigated;
                browser.Navigate(new Uri("https://foursquare.com/oauth2/authorize" +
                   "?client_id=" + AppDetails.clientID+
                   "&redirect_uri=" + AppDetails.urlHomePage +
                   "&response_type=token", UriKind.Absolute));
            }
            static void browser_Navigated(object sender, NavigationEventArgs e)
            {
                string[] parameters = { "#access_token" };
                string result = e.Uri.ToString();

                try
                {
                    result = result.Split(parameters, StringSplitOptions.None)[1];
                    AppDetails.accessToken = result;
                }
                catch (Exception)
                {
                    
                }
            }
            
            /// <summary>
            /// Call this method AFTER you call Authenticate method to get your user's accessToken, and then store it somewhere so you don't have to 
            /// ask your user to Log In to Foursquare everytime.
            /// If you don't call this method AFTER Authenticate method, you'll get a null string
            /// </summary>
            /// <returns>The access token of your user</returns>
            static string GetAccessToken()
            {
                if (AppDetails.accessToken.Length > 0)
                    return AppDetails.accessToken;
                return null;
            }
        }
    }
}
