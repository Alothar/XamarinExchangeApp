using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFExchangeService;
using XamarinExchangeApp.Models;

namespace XamarinExchangeApp.Services.WCFExchangeServiceProxy
{
    class ExchangeRatesServiceProxy : IExchangeRatesServiceProxy
    {
        IExchangeService exchangeService;

        public List<Models.ExchangeRateType> Items { get; private set; }

        public ExchangeRatesServiceProxy()
        {
            exchangeService = new ExchangeServiceClient(
                new BasicHttpBinding(),
                new EndpointAddress(Constants.SoapUrl));
        }

		WCFExchangeService.ExchangeRateType ToWCFServiceExchangeRateItem(Models.ExchangeRateType item)
		{
			return new WCFExchangeService.ExchangeRateType
			{
				Code = item.Code,
				Currency = item.Currency,
				Date = item.Date,
				Rate = item.Rate
			};
		}

		static Models.ExchangeRateType FromWCFServiceExchangeRateItem(WCFExchangeService.ExchangeRateType item)
		{
			return new Models.ExchangeRateType
			{
				Code = item.Code,
				Currency = item.Currency,
				Date = item.Date,
				Rate = item.Rate
			};
		}

		public Task<List<Models.ExchangeRateType>> RefreshDataAsync()
        {
			Items = new List<Models.ExchangeRateType>();

			try
			{
				var ExchangeRateItems =  exchangeService.GetExchangeRateTypes();
				foreach (var item in ExchangeRateItems)
				{
					Items.Add(FromWCFServiceExchangeRateItem(item));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(@"				ERROR {0}", ex.Message);
			}

			return Task.FromResult(Items);
		}
    }
}
