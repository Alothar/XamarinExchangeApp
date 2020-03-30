using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinExchangeApp.Models
{
    public enum MenuItemType
    {
        Exchange_Rates,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
