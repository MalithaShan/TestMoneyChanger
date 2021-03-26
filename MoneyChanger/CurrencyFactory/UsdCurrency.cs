using MoneyChanger.Interface;
using MoneyChanger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyChanger.CurrencyFactory
{
    public class UsdCurrency : ICurrency
    {
        public CurrencyRate GetBuyRate(string type, decimal changeAmount)
        {
            return new CurrencyRate
            {
                Rate = (decimal)1.3392,
                Amount = (decimal)1.3392 * changeAmount
            };
        }

        public CurrencyRate GetSellRate(string type, decimal changeAmount)
        {
            return new CurrencyRate
            {
                Rate = (decimal)1.3574,
                Amount = (decimal)1.3574 * changeAmount
            };
        }
    }
}