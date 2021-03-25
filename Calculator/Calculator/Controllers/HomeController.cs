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

         ViewBag.Display = "0";

         return View();
      }

      // 2nd call to our calculator
      [HttpPost]
      public IActionResult Index(string bt, string display) {

         // process the 'bt' variable, and decide what to do with it
         switch (bt) {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "0":
               // if we clik a 'number', we are going to draw the number on the screen
               if (display == "0") display = bt;
               else display = display + bt;
               break;

            case ",":
               // making the 'display' as double number
               if (!display.Contains(',')) display = display + ',';
               break;

            case "+/-":

               break;

         } // switch (bt)

         // send some information to the View
         ViewBag.Display = display;

         return View();
      }






      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error() {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
