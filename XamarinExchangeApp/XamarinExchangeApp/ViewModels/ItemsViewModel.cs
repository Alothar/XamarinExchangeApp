using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinExchangeApp.Models;
using XamarinExchangeApp.Views;

namespace XamarinExchangeApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<ExchangeRateType> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Exchange Rates";
            Items = new ObservableCollection<ExchangeRateType>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, ExchangeRateType>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as ExchangeRateType;
                Items.Add(newItem);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await App.ExchangeRatesManager.GetExchangeRatesAsync();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}