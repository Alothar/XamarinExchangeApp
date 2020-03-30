using System;
using System.ComponentModel;
using WCFExchangeService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinExchangeApp.Models;
using XamarinExchangeApp.ViewModels;

namespace XamarinExchangeApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Models.ExchangeRateType
            {
                Currency = "Item 1",
                Code = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}