using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    interface IExchange
    {
        string ExchangeName();
        float GetUSDLast(string CryptoCurrency);
        float GetUSDAsk(string CryptoCurrency);
        float GetUSDBid(string CryptoCurrency);


    }
}
