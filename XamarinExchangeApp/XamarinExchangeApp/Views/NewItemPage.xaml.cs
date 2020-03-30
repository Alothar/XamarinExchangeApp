using System;
using System.Collections.Generic;
using System.ComponentModel;
using WCFExchangeService;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinExchangeApp.Models;

namespace XamarinExchangeApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public Models.ExchangeRateType Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Models.ExchangeRateType
            {
                Code = "Currency code."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}