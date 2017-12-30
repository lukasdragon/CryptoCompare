using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.DataTypes;

namespace Core.Handlers
{
    public class Bittrex
    {    
        public string GetTickerJson(string market)
        {            
            var client = new Helpers.RestClient();
            client.EndPoint = main.BittrexApiEndPoint;
            client.Method = HttpVerb.GET;           
            var json = client.MakeRequest("?market=" + market);
            return json;
        }

        public string TestBittrexFormat()
        {
            MarketValues values = new MarketValues
            {
                Bid = 1000,
                Ask = 20000,
                Last = 1500
            };


            BittrexMarket test = new BittrexMarket
            {
                success = false,
                message = "this is a test",
                result = values
            };


            return JsonConvert.SerializeObject(test);
            //BittrexMarket market = JsonConvert.DeserializeObject<BittrexMarket>(Test);
            //return market.Success;
        }



        public bool GetUSDBTC()
        {        
            BittrexMarket market = JsonConvert.DeserializeObject<BittrexMarket>(GetTickerJson("USDT-BTC"));
            
            return market.success;
        }


       


    }
}
