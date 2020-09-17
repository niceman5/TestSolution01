using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine(Sum(1, 2, 3, 4));

            string res = " hi ".ToPlus("bbbbb");

            Console.WriteLine(res);


            Console.WriteLine("--이건 list----");
            List<int> ints = new List<int>();
            int int1 = 10, int2 = 20, int3 = 30;

            ints.Add(int1);
            ints.Add(int2);
            ints.Add(int3);

            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            //배열은 크기를 지정해 줘야 함. list는 크기 지정이 필요 없음.
            //배열은 고정크기라서 추가가 불가
            Console.WriteLine("--이건 array----");
            //int[] ints1 = new int[10];
            int[] ints1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };     //배열생성하면서 초기화 한다.
            ints1[0] = 100;
            foreach (var i in ints1)
            {
                Console.WriteLine(i);
            }

            Car car = new Car();
            car.value = 100;
            car.Run();

            // 모든 class는 object를 base로 상속받음으로....car instance를 전달하고 받는 쪽은 object로 받는다.
            new Program().AsTest(car);
            car.Run();

        }

        void AsTest(object obj)
        {
            // object인 obj를 Car타입인 car로 바꿔준다. as 를 이용....형 변환
            // is 키워드를 통해 자료형의 Type을 확인 할수 있음.

            // 두가지 방법을 둘다 사용가능            
            // Car car = obj as Car;            
            Car car = (Car)obj;
            // 변환 실패시 오류 발생..프로그램 종료 as키워드로 변환하면 실패해도 종료가 안되고 null을 반환하게 됨
            // 직접 캐스팅 보다는 as를 추천함.


            car.Run();
            car.value = 200;
            car.Run();

            bool yes = obj is Car;
            Console.WriteLine(yes);

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }


        /// <summary>
        /// 매개변수의 갯수와 상관없이 받을수 있음.....모두 이걸로 받게 됨
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        static int Sum(params int[] ints)
        {
            Console.WriteLine("다건");
            int sum = 0;
            foreach(int i in ints)
            {
                sum += i;
            }
            return sum;
        }
    }

    public class Car
    {
        public int value { get; set; }
        public void Run()
        {
            Console.WriteLine("Car.Run() .... {0}", this.value);
        }
    }
}
