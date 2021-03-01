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

        /// <summary>
        /// Item을 List로 
        /// </summary>
        public IList<Item> ItemList { get; set; }

        public IActionResult Index()
        {
            DateTime currentTime;

            bool AlreadyExit = _memoryCache.TryGetValue("CachedTime", out currentTime);
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(60));

            if (!AlreadyExit)
            {
                currentTime = DateTime.Now;
                
                _memoryCache.Set("CachedTime", currentTime, cacheEntryOptions);
            }

            List<Item> items;
            List<Item> t = new List<Item>();

            if (_memoryCache.TryGetValue("itemlist", out items) == false)
            {                
                t.Add(new Item() { Id = 1, Borrower = "AAAAA" });
                t.Add(new Item() { Id = 2, Borrower = "BBBBB" });
                t.Add(new Item() { Id = 3, Borrower = "CCCCC" });
                t.Add(new Item() { Id = 4, Borrower = "dddd" });

                _memoryCache.Set("itemlist", t, cacheEntryOptions);
            }
            ItemList = t;
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
