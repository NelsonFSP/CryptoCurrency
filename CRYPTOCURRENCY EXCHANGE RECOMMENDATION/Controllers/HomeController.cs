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

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int ? value, int ? value2)
        {
            List<SelectListItem> tradeitems = new List<SelectListItem> {
                new SelectListItem()
                    {
                        Text = "Bitcoin",
                    Value = "1",
                    Selected = true
                },
                new SelectListItem()
                    {
                        Text = "Ethereum",
                        Value = "2",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Classic Ethereum",
                        Value = "3",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Monero",
                        Value = "4",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Zcash",
                        Value = "5",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Bitcoin cash",
                        Value = "6",
                        Selected = false
                    }
            };
                   
            List<SelectListItem> CoinItems = new List<SelectListItem> {
                new SelectListItem()
                    {
                        Text = "Bitcoin",
                    Value = "1",
                    Selected = true
                },
                new SelectListItem()
                    {
                        Text = "Ethereum",
                        Value = "2",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Classic Ethereum",
                        Value = "3",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Monero",
                        Value = "4",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Zcash",
                        Value = "5",
                        Selected = false
                    },
                new SelectListItem()
                    {
                        Text = "Bitcoin cash",
                        Value = "6",
                        Selected = false
                    }
            };

            ViewBag.TradeItems = tradeitems;
            ViewBag.CoinItems = CoinItems;

            if (value != null)
            {
                switch (Convert.ToInt32(value))
                {
                    case 1:
                        apiCall.getName1(1);
                        break;
                    case 2:
                        apiCall.getName1(2);
                        break;
                    case 3:
                        apiCall.getName1(3);
                        break;
                    case 4:
                        apiCall.getName1(4);
                        break;

                    case 5:
                        apiCall.getName1(5);
                        break;
                    case 6:
                        apiCall.getName1(6);
                        break;
                }
            }
            if (value2 != null)
            {
                switch (Convert.ToInt32(value))
                {
                    case 1:
                        apiCall.getName2(1);
                        break;
                    case 2:
                        apiCall.getName2(2);
                        break;
                    case 3:
                        apiCall.getName2(3);
                        break;
                    case 4:
                        apiCall.getName2(4);
                        break;

                    case 5:
                        apiCall.getName2(5);
                        break;
                    case 6:
                        apiCall.getName2(6);
                        break;
                }
            }

            Console.WriteLine();
            return View();
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
