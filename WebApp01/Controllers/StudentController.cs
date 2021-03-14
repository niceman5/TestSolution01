using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebApp01.Models;

namespace WebApp01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //세션의 값을 가져온다.
            var student = JsonConvert.DeserializeObject<Student>(HttpContext.Session.GetString("StudentSession"));

            return View(student);
        }
    }
}
