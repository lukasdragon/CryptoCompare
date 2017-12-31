using Core.Exchanges;

using System;

namespace TestOutput
{
    static class Program
    {
        static void Main(string[] args)
        {
            Bittrex bittrex = new Bittrex();
            var values = bittrex.GetUSDMinuteLow("BTC");
            foreach (var results in values)
            {
                Console.WriteLine(results);
            }
            Console.ReadLine();
        }
    }
}