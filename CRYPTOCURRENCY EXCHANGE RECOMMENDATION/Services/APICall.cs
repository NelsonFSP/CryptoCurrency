using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers.Requisitions
{
    public class APICalling
    {
        public string FirstUrl = "https://api.coinlore.net/api/tickers/";
        public string SecondUrl = "https://api.coinlore.net/api/tickers/?start=100&limit=100";
        public string ThirdUrl = "https://api.coinlore.net/api/tickers/?start=200&limit=100";

        public static async Task<string> Call()
        {

            try
            {
                IApiService ExchangeClient = RestService.For<IApiService>("https://api.coinlore.net");
                var dataExchange = await ExchangeClient.GetDataAssync();
                return dataExchange.Name.ToString();
                //Console.WriteLine($"{dataExchange.Name.ToString()}");
            }
            catch (Exception e)
            {
                return $"Erro na consulta dos dados " + e.Message;
                //Console.WriteLine("Erro na consulta dos dados: " + e.Message);
            }
        }
    }
}
