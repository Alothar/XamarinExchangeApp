using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinExchangeApp.Models;

namespace XamarinExchangeApp.Services
{
    public interface IExchangeRatesServiceProxy
    {
        Task<List<ExchangeRateType>> RefreshDataAsync();
    }
}
