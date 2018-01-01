using Core.Exceptions;
using Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.DataStructs;


namespace Core.Exchanges
{
    public class Bittrex : IExchange
    {
        private static string BittrexTickerApiEndPoint = @"https://bittrex.com/api/v1.1/public/getticker";
        private static string BittrexHistoricDataEndPoint = @"https://bittrex.com/Api/v2.0/pub/market/GetTicks";

        public string ExchangeName()
        {
            return "Bittrex";
        }

        public float GetUSDLast(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpperInvariant());
            if (market.success)
            {
                return market.result.Last;
            }
            else
            {
                throw new ExchangeServerSideException();
            }
        }

        public float GetUSDAsk(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpperInvariant());
            if (market.success)
            {
                return market.result.Ask;
            }
            else
            {
                throw new ExchangeServerSideException();
            }
        }

        public float GetUSDBid(string CryptoCurrency)
        {
            BittrexMarket market = GetTicker("USDT-" + CryptoCurrency.ToUpperInvariant());
            if (market.success)
            {
                return market.result.Bid;
            }
            else
            {
                throw new ExchangeServerSideException();
            }
        }

        public IDictionary<DateTime, float> GetUSDDailyHigh(string CryptoCurrency)
        {
            HistoricBittrexMarket Historicmarket = GetHistory("USDT-" + CryptoCurrency.ToUpperInvariant(), "day");
            if (Historicmarket.success)
            {
                IDictionary<DateTime, float> Dictionary = new Dictionary<DateTime, float>(); ;
                foreach (var results in Historicmarket.result)
                {
                    Dictionary.Add(results.T, results.H);
                }
                return Dictionary;
            }
            else
            {
                throw new ExchangeServerSideException();
            }
        }

        public IDictionary<DateTime, float> GetUSDDailyLow(string CryptoCurrency)
        {
            HistoricBittrexMarket Historicmarket = GetHistory("USDT-" + CryptoCurrency.ToUpperInvariant(), "day");
            if (Historicmarket.success)
            {
                IDictionary<DateTime, float> Dictionary = new Dictionary<DateTime, float>(); ;
                foreach (var results in Historicmarket.result)
                {
                    Dictionary.Add(results.T, results.L);
                }
                return Dictionary;
            }
            else
                throw new ExchangeServerSideException();
        }

        public IDictionary<DateTime, float> GetUSDMinuteHigh(string CryptoCurrency)
        {
            HistoricBittrexMarket Historicmarket = GetHistory("USDT-" + CryptoCurrency.ToUpperInvariant(), "OneMin");
            if (Historicmarket.success)
            {
                IDictionary<DateTime, float> Dictionary = new Dictionary<DateTime, float>(); ;
                foreach (var results in Historicmarket.result)
                {
                    Dictionary.Add(results.T, results.H);
                }
                return Dictionary;
            }
            else
                throw new ExchangeServerSideException();
        }

        public IDictionary<DateTime, float> GetUSDMinuteLow(string CryptoCurrency)
        {
            HistoricBittrexMarket Historicmarket = GetHistory("USDT-" + CryptoCurrency.ToUpperInvariant(), "OneMin");
            if (Historicmarket.success)
            {
                IDictionary<DateTime, float> Dictionary = new Dictionary<DateTime, float>(); ;
                foreach (var results in Historicmarket.result)
                {
                    Dictionary.Add(results.T, results.L);
                }
                return Dictionary;
            }
            else
                throw new ExchangeServerSideException();
        }


        private BittrexMarket GetTicker(string market)
        {
            var client = new Helpers.RestClient
            {
                EndPoint = BittrexTickerApiEndPoint,
                Method = HttpVerb.GET
            };
            var json = client.MakeRequest("?market=" + market);
            return JsonConvert.DeserializeObject<BittrexMarket>(json);
        }

        private HistoricBittrexMarket GetHistory(string market, string interval)
        {
            var client = new Helpers.RestClient
            {
                EndPoint = BittrexHistoricDataEndPoint,
                Method = HttpVerb.GET
            };
            var json = client.MakeRequest("?marketName=" + market + "&tickInterval=" + interval);
            return JsonConvert.DeserializeObject<HistoricBittrexMarket>(json);
        }
    }
}