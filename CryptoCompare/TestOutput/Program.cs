using Core.Exchanges;

using System;

namespace TestOutput
{
    static class Program
    {
        static void Main(string[] args)
        {
            Gdax gdax = new Gdax();
            gdax.GetTicker("BTC-USD");
            Console.ReadLine();
        }
    }
}