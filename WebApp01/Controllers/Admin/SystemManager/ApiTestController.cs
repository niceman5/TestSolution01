using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp01.Controllers.Admin.SystemManager
{
    [Route("api/[controller]")]
    public class ApiTestController : ControllerBase
    {
        public string Index()
        {
            return "API TEST";
        }

        [HttpGet("{id:alpha}")]
        public string Get(string id)
        {
            return " customName : " + id;
        }

        // GET /api/test/my/3
        [HttpGet("my/{id:int}")]
        public string Get(int id)
        {
            return " my/ customName : " + id.ToString();
        }
    }
}
