using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class DataTypes
    {
        public struct MarketValues
        {
            public float Bid;
            public float Ask;
            public float Last;
            public MarketValues(float bid, float ask, float last)
            {
                Bid = bid;
                Ask = ask;
                Last = last;
            }
        }


        public struct BittrexMarket
        {
            public bool success;
            public string message;
            public MarketValues result;
            public BittrexMarket(bool Success, string Message, MarketValues Result)
            {
                success = Success;
                message = Message;
                result = Result;
            }
        }
    }
}
