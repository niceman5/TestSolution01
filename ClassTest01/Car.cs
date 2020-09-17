using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest01
{
    class Car
    {
        /// <summary>
        /// virtual을 사용하는 이유는 다른 클래스에서 이 클래스를 상속받아서 재정의 해서 사용할수 있게 한다.
        /// </summary>
        public virtual void Run()
        {
            Console.WriteLine("Car Run!!!!!");
        }
    }
}
