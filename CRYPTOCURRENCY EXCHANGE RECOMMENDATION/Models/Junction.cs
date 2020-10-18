using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models
{
    public class Junction
    {
        public SelectList First { get; set; }
        public SelectList Second { get; set; }

    }

    public class FirstSegregation
    {
        public FirstChoose firstChoose { get; set; }
    }

    public class SecondSegregation
    {
        public SecondChoose secondChoose { get; set; }
    }

}
