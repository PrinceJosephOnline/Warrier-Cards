using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using WarrierCards.Website.SecurityService;

namespace WarrierCards.Website.Common
{
    internal class CustomWebSecurity
    {
        #region Member Variables

        /// <summary>
        /// Represents the authentication cookie
        /// </summary>
        public static HttpCookie authCookie;

        /// <summary>
        /// Represents the name of the ticket
        /// </summary>
        private static string ticketName = "WarrierCardsTicket";

        #endregion

        //private static CustomWebSecurity customWebSecurityObj;
        //private CustomWebSecurity() { }

        //internal static CustomWebSecurity Instance()
        //{
        //    if (customWebSecurityObj == null)
        //    {
        //        customWebSecurityObj = new CustomWebSecurity();
        //    }

        //    return customWebSecurityObj;
        //}

        public static int UserId
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["UserId"]); }
            private set { HttpContext.Current.Session["UserId"] = value; }
        }

        public static string Username
        {
            get
            {
                if (HttpContext.Current.Session["Username"] == null && UserId > 0)
                {
                    // TODO: get user name from server, or ID part of the email
                }

                return Convert.ToString(HttpContext.Current.Session["Username"]);
            }
            private set { HttpContext.Current.Session["Username"] = value; }
        }

        internal static bool Login(string email, string password, bool? rememberMe)
        {
            LoginInfo login = new LoginInfo();
            login.Email = email;
            login.Password = password;
            using (var securityService = new SecurityServiceClient())
            {
                UserId = securityService.CheckLogin(login);
            }
            if (UserId > 0)
            {
                SetAuthCookie();
                if (Convert.ToBoolean(rememberMe))
                {
                    HttpCookie cookie = new HttpCookie("WarrierCardsLogin");
                    cookie.Expires = DateTime.Now.AddMonths(1);
                    cookie.Values["Email"] = email;
                    cookie.Values["Password"] = Encrypt(password);
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                else if (rememberMe != null)
                {
                    // TODO
                    // Delete cookie if exists
                    // HttpContext.Current.Response.Cookies["WarrierCardsLogin"]
                    //myCookie.Expires = DateTime.Now.AddDays(-1d);
                    //HttpContext.Current.Response.Cookies.Add(myCookie);
                }
            }

            return true;
            // TODO: see service faul exception is showing meaningful message, if not catch, parse & rethrow
        }

        internal static void Logout()
        {
            HttpContext.Current.Session.Abandon();
            HttpContext.Current.Session.Clear();
            FormsAuthentication.SignOut();
        }

        internal static bool Register(UserInfo userInfo)
        {
            using (var securityService = new SecurityServiceClient())
            {
                securityService.Register(userInfo);
            }
            Login(userInfo.Email, userInfo.Password, false);

            return true;
            // TODO: see service faul exception is showing meaningful message, if not catch, parse & rethrow
        }

        private static void SetAuthCookie()
        {
            authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            if (authCookie == null || string.IsNullOrEmpty(authCookie.Value))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
                               ticketName,
                               DateTime.Now,
                               DateTime.Now.AddMinutes(30), // value of time out property
                               false, // Value of IsPersistent property
                               ",,,,",
                               FormsAuthentication.FormsCookiePath);
                string encryptedTicket = FormsAuthentication.Encrypt(ticket);
                authCookie = new HttpCookie(
                                    FormsAuthentication.FormsCookieName,
                                    encryptedTicket);
                HttpContext.Current.Response.Cookies.Add(authCookie);
            }
        }


        private static string Encrypt(string value)
        {
            byte[] temp = MachineKey.Protect(Encoding.UTF8.GetBytes(value), "EncryptKey");
            string encryptedValue = Convert.ToBase64String(temp);

            return encryptedValue;
        }

        private static string Decrypt(string value)
        {
            byte[] temp = Convert.FromBase64String(value);
            temp = MachineKey.Unprotect(temp, "EncryptKey");
            string decryptedValue = Encoding.UTF8.GetString(temp);

            return decryptedValue;
        }
    }
}