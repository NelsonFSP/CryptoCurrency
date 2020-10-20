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
using javax.jws;
using System.Web.Helpers;

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

        public IActionResult Index()//string value)
        {
            ViewBag.TradeItems = new SelectList(exchangeClass.ListItems().AsEnumerable());
            ViewBag.CoinItems = new SelectList(exchangeClass.ListItems());

            

            //if (value != null){
              //  Chamada(value);
            //}
            //else
            //{
            //   Chamada(null);
            //}
            return View();
        }

        [HttpPost]
        public JsonResult ChamadaTrade(String valor)
        {

            if (valor != null)
            {
                //Console.WriteLine(valor + "Sucesso");
                var saida = valor + " Sucesso";
                return Json(saida);
            }
            else
            {
                var saida = "falha";
                return Json(saida);
            }
        }

        [WebMethod]
        public ActionResult ChamadaCoin(string valor)
        {
            string saida;
            if (valor != null)
            {
                //Console.WriteLine(valor + "Sucesso");
                saida = valor + "Sucesso";
            }
            else
            {
                saida = "falha";
            }

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
