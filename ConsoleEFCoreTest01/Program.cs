using System;
using System.Linq;
using ConsoleEFCoreTest01.Models;

namespace ConsoleEFCoreTest01
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();

            //Employee emp = new Employee
            //{
            //    Name = "홍길동",
            //    DOB = new DateTime(1999, 12, 25),
            //    Salary = 50000
            //};

            //db.Employees.Add(emp);


            //Employee emp2 = new Employee
            //{
            //    Name = "장길산",
            //    DOB = new DateTime(1980, 1, 1),
            //    Salary = 70000
            //};

            //db.Employees.Add(emp2);
            //db.SaveChanges();

            var emp = db.Employees.Where(p => p.Id >= 1).ToList();
            foreach (var item in emp)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
