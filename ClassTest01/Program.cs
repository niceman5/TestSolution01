using System;
using System.Collections.Generic;

namespace ClassTest01
{
    // namespace는 역할이나 의미가 유사한 class들을 특정 범위로 그룹짓는 하나의 방법


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - Main Start!!!");
            
            Car car = new Car();
            car.Run();
            
            
            Bus bus = new Bus();
            bus.Go();
            bus.Run();

            Taxi taxi = new Taxi();
            taxi.Run();
            Bike bike = new Bike();
            bike.Run();

            // 원래 class타입이 틀려서 넣을수 없는데 모두 Car를 상속받아서 
            // 넣을수 있음
            List<Car> cars = new List<Car>();
            cars.Add(bike);
            cars.Add(taxi);
            cars.Add(bus);

            Console.WriteLine("--------------------------");
            foreach (var item in cars)
            {
                item.Run();
            }
        }
    }
}
