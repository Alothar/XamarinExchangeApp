using Xamarin.Forms;

namespace XamarinExchangeApp.Services.WCFExchangeServiceProxy
{
    public static class Constants
    {
        public static string SoapUrl
        {
            get
            {
                var defaultUrl = "http://localhost:55987/ExchangeService.svc";

                if (Device.RuntimePlatform == Device.Android)
                {
                    defaultUrl = "http://10.0.2.2:55987/ExchangeService.svc";
                }
                else if (Device.RuntimePlatform == Device.iOS)
                {
                    defaultUrl = "http://192.168.1.143:55987/ExchangeService.svc";
                }

                return defaultUrl;
            }
        }
    }
}
