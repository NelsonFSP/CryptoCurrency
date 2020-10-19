using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models
{
    public enum ExchangeList
    {

        Bitcoin,
        
        Ethereum,

        [Display(Name = "Classic Ethereum")]
        
        ClassicEthereum,
        
        Monero,
        
        Zcash,
        
        [Display(Name = "Bitcoin Cash")]
        
        BitcoinCash
    }

}
