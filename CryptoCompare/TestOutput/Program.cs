using Core.Exchanges;

using System;

namespace TestOutput
{
    class Program
    {

        static void Main(string[] args)
        {
            

            while (true)
            {
                Bittrex bittrex = new Bittrex();
                Console.WriteLine("ASK: $" + bittrex.GetUSDAsk("BTC"));
                Console.WriteLine("BID: $" + bittrex.GetUSDBid("BTC"));
                Console.WriteLine("LAST: $" + bittrex.GetUSDLast("BTC"));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
