using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers.Requisitions;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers
{
    public class HomeController : Controller
    {
        public APICall apiCall = new APICall();
        public ExchangeClass exchangeClass = new ExchangeClass();
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? value)
        {
            ViewBag.TradeItems = new SelectList(exchangeClass.ListItems().AsEnumerable());
            ViewBag.CoinItems = new SelectList(exchangeClass.ListItems());

            

            if (value != null){
                Chamada(value);
            }
            else
            {
                Chamada(null);
            }
            return View();
        }

        [Microsoft.JSInterop.JSInvokable]
        public static bool Chamada(string value)
        {
            if (value != null)
            {
                Console.WriteLine(value + "Sucesso");
                return true;
            }
            else
            {
                Console.WriteLine(value + "Deu erro");
                return false;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
