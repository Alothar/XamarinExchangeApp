using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinExchangeApp.Models
{
    public class ExchangeRateType
    {
        string currency;
        string code;
        string date;
        double rate;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
