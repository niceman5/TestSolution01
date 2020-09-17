using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest01
{
    class Bike : Car
    {
        public override void Run()
        {
            //base.Run();
            Console.WriteLine("Bike Run!!!");
        }

    }
}
