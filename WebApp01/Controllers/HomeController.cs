using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp01.Models;
using WebApp01.Models.Holiday;

namespace WebApp01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHolidaysApiService _holidaysApiService;

        public HomeController(ILogger<HomeController> logger, IHolidaysApiService holidaysApiService)
        {
            _logger = logger;
            _holidaysApiService = holidaysApiService;
        }


        public async Task<IActionResult> Holiday(string countryCode = "kr", int year = 2021)
        {
            List<HolidayModel> holidays = new List<HolidayModel>();
            holidays = await _holidaysApiService.GetHolidays(countryCode, year);
            return View(holidays);
        }

        public IActionResult Index()
        {
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

        public string Test() 
        {
            return "Hello Test!!!!";
        }
    }
}
