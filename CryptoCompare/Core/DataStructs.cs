using System;
using System.Collections.Generic;

namespace Core
{
    public class DataStructs
    {
        public struct BittrexMarketValues
        {
            public float Bid;
            public float Ask;
            public float Last;
            public BittrexMarketValues(float bid, float ask, float last)
            {
                Bid = bid;
                Ask = ask;
                Last = last;
            }
        }

        public struct GdaxMarketValues
        {
            public int Trade_id;
            public float Price;
            public float Size;
            public float Bid;
            public float Ask;
            public float Volume;
            public DateTime Time;
            public GdaxMarketValues(int trade_id, float price, float size, float bid, float ask, float volume, string time)
            {
                Trade_id = trade_id;
                Price = price;
                Size = size;
                Bid = bid;
                Ask = ask;
                Volume = volume;
                Time = DateTime.Parse(time);
            }
            
        }

        public struct BittrexMarket
        {
            public bool success;
            public string message;
            public BittrexMarketValues result;
            public BittrexMarket(bool Success, string Message, BittrexMarketValues Result)
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