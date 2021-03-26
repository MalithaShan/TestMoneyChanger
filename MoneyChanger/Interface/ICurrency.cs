using MoneyChanger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyChanger.Interface
{
    public interface ICurrency
    {
        CurrencyRate GetBuyRate(string type, decimal changeAmount);
        CurrencyRate GetSellRate(string type, decimal changeAmount);
    }
}
