using GenericCRUDApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericCRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController : GenericCRUDController<ToDoItem>
    {
        public ToDoItemController(DataContext context) : base(context)
        {

        }
    }
}
