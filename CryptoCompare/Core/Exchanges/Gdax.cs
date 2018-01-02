using Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static Core.DataStructs;

namespace Core.Exchanges
{
    public class Gdax : IExchange
    {
        private string GdaxTickerApiEndPoint = @"https://api.gdax.com/products/BTC-USD/ticker";


        public string ExchangeName()
        {
            return "CoinBase";
        }

        public float GetUSDAsk(string CryptoCurrency)
        {
            GdaxMarketValues market = GetTicker("USD-" + CryptoCurrency.ToUpperInvariant());
            return market.Ask;          
        }

        public float GetUSDBid(string CryptoCurrency)
        {
            GdaxMarketValues market = GetTicker("USD-" + CryptoCurrency.ToUpperInvariant());
            return market.Bid;
        }

        public float GetUSDLast(string CryptoCurrency)
        {
            GdaxMarketValues market = GetTicker("USD-" + CryptoCurrency.ToUpperInvariant());
            return market.Price;
        }

        public IDictionary<DateTime, float> GetUSDDailyHigh(string CryptoCurrency)
        {
            throw new NotImplementedException();
        }

        public IDictionary<DateTime, float> GetUSDDailyLow(string CryptoCurrency)
        {
            throw new NotImplementedException();
        }       

        public IDictionary<DateTime, float> GetUSDMinuteHigh(string CryptoCurrency)
        {
            throw new NotImplementedException();
        }

        public IDictionary<DateTime, float> GetUSDMinuteLow(string CryptoCurrency)
        {
            throw new NotImplementedException();
        }

        private GdaxMarketValues GetTicker(string market)
        {         
            var client = new Helpers.RestClient
            {
                EndPoint = GdaxTickerApiEndPoint,
                Method = HttpVerb.GET,
                ContentType = "application/json"
            };
            var json = client.MakeRequest();
            return JsonConvert.DeserializeObject<GdaxMarketValues>(json);
        }    
    }
}