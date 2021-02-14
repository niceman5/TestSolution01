using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleEFCoreTest01.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int  Salary { get; set; }
    }
}
