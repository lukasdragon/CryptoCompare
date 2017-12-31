using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    interface IExchange
    {
        /// <summary>
        /// The name of the exchange Example: Bittrex
        /// </summary>
        /// <returns>name as string</returns>
        string ExchangeName();
        /// <summary>
        /// The last transaction in USD
        /// </summary>
        /// <param name="CryptoCurrency"></param>
        /// <returns>value as float</returns>
        float GetUSDLast(string CryptoCurrency);
        /// <summary>
        /// Asking price in USD
        /// </summary>
        /// <param name="CryptoCurrency"></param>
        /// <returns>value as float</returns>
        float GetUSDAsk(string CryptoCurrency);
        /// <summary>
        /// Biding price in USD
        /// </summary>
        /// <param name="CryptoCurrency"></param>
        /// <returns>value as float</returns>
        float GetUSDBid(string CryptoCurrency);
        /// <summary>
        /// Returns daily historic market high in USD
        /// </summary>
        /// <returns>dictionary</returns>
        IDictionary<DateTime, float> GetUSDDailyHigh(string CryptoCurrency);
        /// <summary>
        /// Returns daily historic market low in USD
        /// </summary>
        /// <returns>dictionary</returns>
        IDictionary<DateTime, float> GetUSDDailyLow(string CryptoCurrency);
        /// <summary>
        /// Returns historic market high in USD in minute intervals 
        /// </summary>
        /// <returns>dictionary</returns>
        IDictionary<DateTime, float> GetUSDMinuteHigh(string CryptoCurrency);
        /// <summary>
        /// Returns historic market low in USD in minute intervals
        /// </summary>
        /// <returns>dictionary</returns>
        IDictionary<DateTime, float> GetUSDMinuteLow(string CryptoCurrency);

    }
}
