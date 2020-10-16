using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers.Requisitions
{
    public class APICall
    {
        public String getName1(int val1)
        {
            if (val1 < 0)
            {
                return "primeiro JSON" + val1.ToString();
            }
            return "Erro de chamada API" + val1.ToString();
        }

        public String getName2(int val2)
        {
            if (val2 < 0)
            {
                return "primeiro JSON" + val2.ToString();
            }
            return "Erro de chamada API" + val2.ToString();
        }
    }
}
