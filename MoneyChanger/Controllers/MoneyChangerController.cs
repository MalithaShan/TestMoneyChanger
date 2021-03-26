using MoneyChanger.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoneyChanger.CurrencyFactory;
using MoneyChanger.Models;

namespace MoneyChanger.Controllers
{
    public class MoneyChangerController : ApiController
    {
        [Route("api/GetBuyRate/{type}/{changeAmount}")]
        public CurrencyRate GetBuyRate(string type, decimal changeAmount)
        {
            ICurrency iCurrencyFactory = MoneyChanger.CurrencyFactory.CurrencyFactory.GetCurrency(type);
            return iCurrencyFactory.GetBuyRate(type, changeAmount);
        }

        [Route("api/GetSellRate/{type}/{changeAmount}")]
        public CurrencyRate GetSellRate(string type, decimal changeAmount)
        {
            ICurrency iCurrencyFactory = MoneyChanger.CurrencyFactory.CurrencyFactory.GetCurrency(type);
            return iCurrencyFactory.GetSellRate(type, changeAmount);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
