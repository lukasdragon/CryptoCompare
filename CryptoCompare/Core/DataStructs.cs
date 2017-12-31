using System;
using System.Collections.Generic;

namespace Core
{
    public class DataStructs
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

        public struct HistoricMarketValues
        {
            public float O;
            public float H;
            public float L;
            public float C;
            public float V;
            public DateTime T;
            public float BV;
            public HistoricMarketValues(float o, float h, float l, float c, float v, string t, float bv)
            {
                O = o;
                H = h;
                L = l;
                C = c;
                V = v;
                T = DateTime.Parse(t);
                BV = bv;
            }
        }

        public struct HistoricBittrexMarket
        {
            public bool success;
            public string message;
            public IList<HistoricMarketValues> result;
            public HistoricBittrexMarket(bool Success, string Message, IList<HistoricMarketValues> Result)
            {
                success = Success;
                message = Message;
                result = Result;
            }
        }
    }
}