using System;
using System.Threading;

namespace ConsoleDelegate
{

    /*
     * 우리가 보통 메서드를 사용할때 그 매개변수로 변수를 넘김
     * 그런데 메서드의 메개변수로 메서드를 넘겨줄수 있음.
     * 이 메서드의 매개변수로 넘기는 매서드를 델리게이트라고 함.
     * 다른 말로는 콜백이라고도 함.
     * 콜백은 다른 코드의 인수로서 넘겨주는 실행가는한 코드를 의미함.
     */

    class Program
    {
        delegate void Del();        // 델리게이트 정의 : 델리게이트 원형
        Del manager;                // 델리게이트 객체를 선언


        Class1 class1 = new Class1();   
        Class2 class2 = new Class2();
        Class3 class3 = new Class3();


        public Program()
        {
            // 이벤트 핸들러처럼 메서드 등록해놓고 사용하는 델리게이트 체인
            manager += new Del(class1.StringPlus1);     // 델리게이트에 담는다. 델리게이트 객체에 메서드를 담고 있음.
            manager += delegate { Console.WriteLine("hello2"); };       // 무명 메서드 이용
            manager += class3.StringPlus3;
            manager += (() => Console.WriteLine("hello4"));
            manager += (() =>
            {
                // 람다식 이용
                Console.WriteLine("hello5");
                Console.WriteLine("hello555");
            });
            // 여러개의 델리게이트 객체들을 각기 다들 형태로 하나 하나 더한 것
            // manager에 4개를 더함.

            // 이벤트 핸들러를 등록하는 예(여기서 EventHandler는 델리게이트 객체 / btn_Click은 콜백 메서드 / Click은 이벤트)

            // event EventHandler click = new EventHandler(ClickCallback);
            // btn.Click += click;
            // 또는 btn.Click += new EventHandler(ClickCallback)
            // ClickCallback : 콜백메서드.....
            // 이벤트를 생성하고 이벤트 연결...
        }

        static void Main(string[] args)
        {
            new Program().manager();          // 델리게이트 체인을 사용
                                              // 델리게이트 객체를 이렇게 실행하면 여기에 담긴 메서드들이 실행됨

            Class1 class1 = new Class1();   // 델리게이트 체인을 사용하지 않음
            Class2 class2 = new Class2();
            Class3 class3 = new Class3();

            class1.StringPlus1();
            class2.StringPlus2();
            class3.StringPlus3();

            new Thread(new ThreadStart(class1.StringPlus1)).Start();

            Manager(class1.StringPlus1);
            Console.ReadLine();

        }

        /// <summary>
        /// 델리게이트를 매개변수로 받음.
        /// </summary>
        /// <param name="dele"></param>
        static void Manager(Del dele)       // 콜백(callback)함수를 매개변수로 받는 함수.
        {
            dele();
        }

        static void ClickCallBack(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }

        /// <summary>
        /// 델리게이트의 원형과 동일한 형태만 델리게이트에 담을수 있음. return타입이 void고 인수가 없음. 
        /// </summary>
        class Class1
        {
            public void StringPlus1()
            {
                Console.WriteLine("hello1");
            }
        }
        class Class2
        {
            public void StringPlus2()
            {
                Console.WriteLine("hello2");
            }
        }
        class Class3
        {
            public void StringPlus3()
            {
                Console.WriteLine("hello3");
            }
        }
    }
}
