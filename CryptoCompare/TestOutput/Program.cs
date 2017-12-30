using Core.Handlers;
using System;

namespace TestOutput
{
    class Program
    {

        static void Main(string[] args)
        {
            Bittrex bittrex = new Bittrex();
            Console.WriteLine(bittrex.TestBittrexFormat());
           //  Console.WriteLine(bittrex.GetTickerJson("USDT-BTC"));
           // Console.WriteLine(bittrex.GetUSDBTC());
            Console.ReadKey();
        }
    }
}
