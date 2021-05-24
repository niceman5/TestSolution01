using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerialize
{
    public class Customer
    {
        public int seq { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public bool Sex { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // class내용을 xml파일에 저장하고 읽어서 표시한다.
            Customer c = new Customer { seq = 1, CompanyName = "가나다라", Name = "홍길동", Sex = true };
            string write_path = @"C:\00.Dev\temp\Emp.xml";      //집 pc
            string read_path = @"C:\00.Dev\temp\Emp.xml";      //집 pc
            // string write_path = @"D:\00.Dev\dotnetProject\TestSolution01\XMLSerialize\Emp.xml";   //회사 pc
            // string read_path = @"D:\00.Dev\dotnetProject\TestSolution01\XMLSerialize\Emp.xml";   //회사 pc


            using (StreamWriter sw = new StreamWriter(write_path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Customer));
                xs.Serialize(sw, c);
            }

            // xml파일을 읽어서 class에 매칭
            using (StreamReader sr=new StreamReader(read_path))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Customer));
                Customer c1 = (Customer)xs.Deserialize(sr);

                Console.WriteLine(c1.seq);
                Console.WriteLine(c1.Name);
                Console.WriteLine(c1.CompanyName);
                Console.WriteLine(c1.Sex);
                Console.ReadLine();
            }
        }
    }
}
