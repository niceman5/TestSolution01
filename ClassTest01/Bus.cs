using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest01
{
    class Bus : Car
    {
        public void Go()
        {
            Console.WriteLine("Go Bus!");
        }

        //재정의한다.s
        public override void  Run() 
        {
            Console.WriteLine("Bus Run!!!");
        }

    }
}
