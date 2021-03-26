using MoneyChanger.Interface;
using MoneyChanger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyChanger.CurrencyFactory
{
    public class HkdCurrency : ICurrency
    {
        public CurrencyRate GetBuyRate(string type, decimal changeAmount)
        {
            return new CurrencyRate
            {
                Rate = (decimal)0.1738,
                Amount = Math.Round((decimal)0.1738 * changeAmount, 1)
            };
        }

        public CurrencyRate GetSellRate(string type, decimal changeAmount)
        {
            return new CurrencyRate
            {
                Rate = (decimal)0.1698,
                Amount = (decimal)0.1698 * changeAmount
            };
        }
    }
}