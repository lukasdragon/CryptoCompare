using Core.Exchanges;

using System;

namespace TestOutput
{
    class Program
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