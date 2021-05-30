using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericCRUDApi.Models
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime EntryDate{ get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
