using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinExchangeApp.Models;
using XamarinExchangeApp.Services;

namespace XamarinExchangeApp.WCFService
{
    public class ExchangeRatesManager
    {
        IExchangeRatesServiceProxy exchangeRatesProxy;

		public ExchangeRatesManager(IExchangeRatesServiceProxy service)
		{
			exchangeRatesProxy = service;
		}

		public Task<List<ExchangeRateType>> GetExchangeRatesAsync()
		{
			return exchangeRatesProxy.RefreshDataAsync();
		}
	}
}