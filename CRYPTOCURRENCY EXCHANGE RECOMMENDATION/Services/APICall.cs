using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers.Requisitions
{
    public class APICall
    {
        public string FirstUrl = "https://api.coinlore.net/api/tickers/";
        public string SecondUrl = "https://api.coinlore.net/api/tickers/?start=100&limit=100";
        public string ThirdUrl = "https://api.coinlore.net/api/tickers/?start=200&limit=100";

        public async Task<T> Index()
        {
            List<Data> reservationList = new List<Data>();
            using (var httpClient = new HttpClient())
            {
                for(int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            using (var response = await httpClient.GetAsync(FirstUrl)) ;
                            break;
                    }
                    using var response = await httpClient.GetAsync();
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservationList = JsonConvert.DeserializeObject<List<Data>>(apiResponse);
                }
                
            }
            return View(reservationList);
        }



    }
}
