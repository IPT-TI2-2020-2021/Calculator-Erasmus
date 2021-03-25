using Calculator.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers {
   public class HomeController : Controller {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger) {
         _logger = logger;
      }



      /// <summary>
      /// 1st call to the View
      /// </summary>
      /// <returns></returns>
      [HttpGet]
      public IActionResult Index() {
         return View();
      }

      // 2nd call to our calculator
      [HttpPost]
      public IActionResult Index( string bt ) {





         return View();
      }






      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error() {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
