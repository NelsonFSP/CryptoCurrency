using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models
{
    public class ExchangeClass
    {
        public int CoinId { get; set; }
        public ExchangeList Coin { get; set; } 

        public List<SelectListItem> Items { get; set; }

        public List<ExchangeList> ListItems()
        {
            List<ExchangeList> list = Enum.GetValues(typeof(ExchangeList))
                        .Cast<ExchangeList>()
                        .ToList();
            //var listFromExchangeClass = from ExchangeList1 el in Enum.GetValues (typeof(ExchangeList1))
            //                            select new SelectListItem
            //                            {
            //                                Value = ((int)el).ToString(),
            //                                Text = Enum.GetName(typeof(ExchangeList1), el),
            //                                Selected = CoinId == (int)el ? true : false
            //                            };
            //Items = listFromExchangeClass.ToList();

            return list;
        }
    }
}
