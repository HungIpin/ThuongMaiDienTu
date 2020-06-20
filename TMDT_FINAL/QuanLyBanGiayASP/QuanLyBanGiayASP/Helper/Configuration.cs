using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal.Account;
using PayPal.Api;
using QuanLyBanGiayASP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyBanGiayASP.Models.ViewModels;
using System.Threading.Tasks;

namespace QuanLyBanGiayASP.Helper
{
    public class Configuration
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;
        Access a = new Access();


        static Configuration()
        {
            var config = GetConfig();
            ClientId = config["clientId"];
            ClientSecret = config["clientSecret"];
        }
        public static Dictionary<string, string> GetConfig()
        {
            return PayPalService.GetPayPalConfig();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(ClientId, ClientSecret, GetConfig()).GetAccessToken();
        
          

            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apiContext = new APIContext(GetAccessToken());
            apiContext.Config = GetConfig();
            return apiContext;
        }
    }
}
