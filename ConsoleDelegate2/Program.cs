using System;

namespace ConsoleDelegate2
{
    /*
     * 미리 준비된 델리게이트 사용
     */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            
            // 어떤 하나의 매개변수를 받고 리턴형은 void.
            Action<int> action = (int s) => { Console.WriteLine(s + 5); };
            action(a);
            Action action2 = () => { Console.WriteLine(5); };               //매개변수 없이 사용
            action2();

            // 하나가 매개변수이고 하나가 리턴 타입.
            Func<int, int> func = (int s) => { return s + 5;  };
            Console.WriteLine(func(a));
            // 리턴타입만 있음...
            Func<int> func2 = () => { return 5; };
            Console.WriteLine(func2());


            // bool을 리턴한다.
            Predicate<int> predicate = delegate (int s)
            {
                return s > 5;
            };
            Console.WriteLine(predicate(a));

            // 델리게이트 미사용시....
            // class선언하고 별도의 메서드 만들어서 호출해야 함.
            // 델리게이트 사용하면 이런걸 줄일수 있음...
            Program program = new Program();
            program.Plus(a);
        }

        void Plus(int s)
        {
            Console.WriteLine(s+5);
        }
    }
}
