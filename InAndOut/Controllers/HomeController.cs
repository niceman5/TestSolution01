using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache _memoryCache;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache)
        {
            _logger = logger;

            this._memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            DateTime currentTime;

            bool AlreadyExit = _memoryCache.TryGetValue("CachedTime", out currentTime);

            if (!AlreadyExit)
            {
                currentTime = DateTime.Now;
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(20));
                _memoryCache.Set("CachedTime", currentTime, cacheEntryOptions);

            }

            return View(currentTime);
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
