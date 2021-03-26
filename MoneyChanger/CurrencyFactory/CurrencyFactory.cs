using MoneyChanger.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyChanger.CurrencyFactory
{
    public class CurrencyFactory
    {
        public static ICurrency GetCurrency(string type) 
        {
            ICurrency currency = null;
            switch (type.ToUpper()) 
            {
                case "USD":
                    currency = new UsdCurrency();
                    break;
                case "HKD":
                    currency = new HkdCurrency();
                    break;
            
            }
            return currency;
        }
    }
}