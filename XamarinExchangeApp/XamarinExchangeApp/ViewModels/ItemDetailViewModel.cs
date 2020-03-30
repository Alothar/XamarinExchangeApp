using System;
using WCFExchangeService;
using XamarinExchangeApp.Models;

namespace XamarinExchangeApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Models.ExchangeRateType Item { get; set; }
        public ItemDetailViewModel(Models.ExchangeRateType item = null)
        {
            Title = item?.Currency;
            Item = item;
        }
    }
}
