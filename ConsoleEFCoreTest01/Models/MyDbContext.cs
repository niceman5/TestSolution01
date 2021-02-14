using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEFCoreTest01.Models
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source(local);Inital Catalog=dev;Intergrated Security=SSPI");
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = dev; Integrated Security = False; User Id = niceman5; Password = gustnr35; MultipleActiveResultSets = True;");
        }


        /// <summary>
        /// Employees속성을 통해 테이블 데이터를 엑세스한다는 뜻
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
    }
}
