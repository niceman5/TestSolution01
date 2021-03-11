using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            // https://localhost:44385/Test
            // Views/Test/index.cshtml 호출 
            return View();
        }

        public string Test(){
            // https://localhost:44385/test/test
            return "Hello Test@@@@@@";
        }
    }
}
