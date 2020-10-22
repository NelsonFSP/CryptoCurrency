using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Services
{
    public interface IApiService
    {
        [Get("/api/tickers/")]
        Task<Data> GetDataAssync();
    }
}
