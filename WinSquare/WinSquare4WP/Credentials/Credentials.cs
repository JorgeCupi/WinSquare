using System;

namespace WinSquare
{
    namespace Credentials
    {
        /// <summary>
        /// Class that contains sensible information such as your Application's clientSecret, clientID or your user's accessToken
        /// You have to store this info here using the methods from the Login class located in the Authenticate namespace
        /// </summary>
        public class AppDetails
        {
            /// <summary>Represents your Application's clientSecret provided by Foursquare</summary>
            public static string clientSecret { get; set; }

            /// <summary>Represents your Application's clientID provided by Foursquare</summary>
            public static string clientID { get; set; }
            
            /// <summary>Represents your user's accessToken provided by Foursquare when you let your user authenticate via Authenticate method on Login class</summary>
            public static string accessToken { get; set; }

            /// <summary>Represents your Application's home web page</summary>
            public static string urlHomePage { get; set; }

            /// <summary>Represents your Application's privacy web page</summary>
            public static string urlPrivacyPage { get; set; }

            /// <summary>Represents your Application's callback web page</summary>
            public static string urlCallBackPage { get; set; }
        }
    }
}
