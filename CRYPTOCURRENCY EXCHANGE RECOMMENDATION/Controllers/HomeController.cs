using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRYPTOCURRENCY_EXCHANGE_RECOMMENDATION.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem()
            {
                Text = "Bitcoin",
                Value = "1",
                Selected = true
            };
            SelectListItem item2 = new SelectListItem()
            {
                Text = "Ethereum",
                Value = "2",
                Selected = false
            };
            SelectListItem item3 = new SelectListItem()
            {
                Text = "Classic Ethereum",
                Value = "3",
                Selected = false
            };
            SelectListItem item4 = new SelectListItem()
            {
                Text = "Monero",
                Value = "4",
                Selected = false
            };
            SelectListItem item5 = new SelectListItem()
            {
                Text = "Zcash",
                Value = "5",
                Selected = false
            };
            SelectListItem item6 = new SelectListItem()
            {
                Text = "Bitcoin cash",
                Value = "6",
                Selected = false
            };
            items.Add(item1);
            items.Add(item3);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);
            items.Add(item5);
            items.Add(item6);

            ViewBag.TradeItems = items;
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
