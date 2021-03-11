using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Controllers.Admin.SystemManager
{

    //[Route("admin/system/[controller]")]
    public class UmsFeeController : Controller
    {
        [Route("admin/system/[controller]")]
        public IActionResult Index()
        {
            ///https://localhost:44385/admin/system/umsfee
            return View();
        }

        [Route("admin/system/[controller]/[action]")]
        public string Test()
        {
            //https://localhost:44385/admin/system/umsfee/test
            return "UmsFee_Test";
        }
    }
}
