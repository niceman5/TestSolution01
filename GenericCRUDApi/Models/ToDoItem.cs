using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericCRUDApi.Models
{
    public class ToDoItem:EntityBase
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
