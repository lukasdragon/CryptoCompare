using Core.Exchanges;

using System;

namespace TestOutput
{
    static class Program
    {
        static void Main(string[] args)
        {
            Bittrex bittrex = new Bittrex();
            Console.WriteLine(bittrex.GetUSDLast("BTC"));
            Gdax gdax = new Gdax();
            Console.WriteLine(gdax.GetUSDLast("BTC"));
            Console.ReadLine();
        }
    }
}