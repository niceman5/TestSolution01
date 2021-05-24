using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var file_name = @"C:\00.Dev\VSTestProject\TestSolution01\XML_Linq\store.xml";

            XElement storeXML = XElement.Load(file_name);

            var beers = from e in storeXML.Element("beers").Elements("beer")
                            // where e.Attribute("style").Value == "porter"
                            // orderby e.Value
                        orderby e.Attribute("style").Value
                        //select e;
                        select new Beer
                        {
                            Name = e.Value,
                            Style = e.Attribute("style").Value
                        };


            foreach (var beer in beers)
            {
                //Console.WriteLine(beer);
                //Console.WriteLine(beer.Value);
                //Console.WriteLine($"{ beer.Value } { beer.Attribute("style").Value }");

                Console.WriteLine($"{ beer.Name} { beer.Style }");
            }
            Console.ReadLine();
            
        }
    }
    public class Beer
    {
        public string Name;
        public string Style;
    }
}
