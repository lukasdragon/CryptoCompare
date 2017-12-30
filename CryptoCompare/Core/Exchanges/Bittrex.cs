using Core.Exceptions;
using Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.DataTypes;

namespace Core.Exchanges
{
    public class Bittrex : IExchange
    {
        private BittrexMarket GetTicker(string market)
        {
            var client = new Helpers.RestClient
            {
                EndPoint = Main.BittrexApiEndPoint,
                Method = HttpVerb.GET
            };
            var json = client.MakeRequest("?market=" + market);
            return JsonConvert.DeserializeObject<BittrexMarket>(json);
        }

        public string ExchangeName()
        {
            return "Bittrex";
        }



        public float GetUSDLast(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpper());
            if (market.success)
                return market.result.Last;
            else
                throw new ExchangeServerSideException();
        }

        public float GetUSDAsk(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpper());
            if (market.success)
                return market.result.Ask;
            else
                throw new ExchangeServerSideException();
        }

        public float GetUSDBid(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpper());
            if (market.success)
                return market.result.Bid;
            else
                throw new ExchangeServerSideException();
        }
    }
}
