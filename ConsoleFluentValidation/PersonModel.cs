using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFluentValidation
{
    class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
