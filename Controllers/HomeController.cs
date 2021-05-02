using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SandboxJScalc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SandboxJScalc.Controllers
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
            return View();
        }

        public ActionResult Recalc(decimal Amount1, decimal Amount2)
        {
            decimal TotalAmount = Amount1 + Amount2;
            return Json(new { totalamount = TotalAmount });
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

        [HttpPost]
        public ViewResult Index(CommonInfo Common)
        {
            ModelState.AddModelError("VMessage", "Thank You!");
            return View("Index");
        }
    }
}
