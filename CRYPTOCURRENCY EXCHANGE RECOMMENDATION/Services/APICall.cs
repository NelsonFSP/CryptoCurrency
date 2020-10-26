using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Services;
using Microsoft.AspNetCore.Mvc;
using Refit;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers.Requisitions
{
    public class APICalling
    {
        public string FirstUrl = "https://api.coinlore.net/api/tickers/";
        public string SecondUrl = "https://api.coinlore.net/api/tickers/?start=100&limit=100";
        public string ThirdUrl = "https://api.coinlore.net/api/tickers/?start=200&limit=100";

        [HttpGet("")]
        public static async Task<string> Call()
        {
            try
            {
                IApiService ExchangeClient = RestService.For<IApiService>("https://api.coinlore.net/api/tickers/");
                var dataExchange = await ExchangeClient.GetDataAssync();
                return saida;
            }
            catch (Exception e)
            {
                return $"Erro na consulta dos dados " + e.Message;
            }
        }
    }
}
