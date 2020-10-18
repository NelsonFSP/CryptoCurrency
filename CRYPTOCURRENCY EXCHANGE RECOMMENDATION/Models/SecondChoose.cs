using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models
{
    public class SecondChoose
    {
        public List<SelectListItem> SecondItems = new List<SelectListItem>
        {
            new SelectListItem()
                {
                    Text = ExchangeList1.Bitcoin.ToString(),
                    Value = "1",
                    Selected = false
                },
            new SelectListItem()
                {
                    Text = ExchangeList1.Ethereum.ToString(),
                    Value = "2",
                    Selected = false
                },
            new SelectListItem()
                {
                    Text = ExchangeList1.ClassicEthereum.ToString(),
                    Value = "3",
                    Selected = false
                },
            new SelectListItem()
                {
                    Text = ExchangeList1.Monero.ToString(),
                    Value = "4",
                    Selected = false
                },
            new SelectListItem()
                {
                    Text = ExchangeList1.Zcash.ToString(),
                    Value = "5",
                    Selected = false
                },
            new SelectListItem()
                {
                    Text = ExchangeList1.BitcoinCash.ToString(),
                    Value = "6",
                    Selected = false
                }
        };
    }
}
