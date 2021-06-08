using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public ActionResult Recalc(int Amount1, int Amount2)
        {
            int TotalAmount = Amount1 + Amount2;
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
            if (Convert.ToString(Request.Form["DropDownTest"]) != null)
            {
                DateTime CurrentDate = DateTime.Now;
                int CurrentYear = CurrentDate.Year;

                Common.MonthList = new();
                Common.YearList = new();

                for (int i = 1; i <= 12; i++)
                {
                    string MonthName = new DateTime(CurrentYear, i, 1).ToString("MMMM");
                    Common.MonthList.Add(new SelectList(MonthName, MonthName));
                }

                
                string YearAsText;
                YearAsText = (CurrentYear - 1).ToString();
                Common.YearList.Add(new SelectList(YearAsText, YearAsText));
                YearAsText = CurrentYear.ToString();
                Common.YearList.Add(new SelectList(YearAsText, YearAsText));
                YearAsText = (CurrentYear + 1).ToString();
                Common.YearList.Add(new SelectList(YearAsText, YearAsText));

                return View("DDdemo", Common);
            }
            return View("Index");
        }
    }
}
