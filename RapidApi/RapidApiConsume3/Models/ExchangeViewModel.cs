using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RapidApiConsume3.Models;



namespace RapidApiConsume3.Models
{
    public class ExchangeViewModel
    {
       
            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public Data data { get; set; }
   

        public class Data
        {
            public string base_currency { get; set; }
            public string base_currency_date { get; set; }
            public Exchange_Rates[] exchange_rates { get; set; }
        }

        public class Exchange_Rates
        {
            public string currency { get; set; }
            public string exchange_rate_buy { get; set; }
        }


    }


}

