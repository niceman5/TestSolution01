using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSyncTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("단일 쓰레드");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            long sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("단위 실행 종료");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread thread = new Thread(Test);
            thread.Start();
        }


        private void Test()
        {
            Console.WriteLine("멀티 쓰레드");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            long sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("단위 실행 종료");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("동기 출력 - 단일 쓰레드");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            long sum = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;
            }
            Console.WriteLine("단위 실행 종료");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("비동기 출력 - 멀티 쓰레드");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            
            // 메서드를 델리게이트로 Task라는 클래스에 넘겨줬을때는 스레드를 별도로 생성하여 멀티쓰레드로 동작한다.
            var task1 = Task.Run(() => Sum());
            long sum = await task1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine("비동기 출력 - 단일 쓰레드");
            Test1();
        }

        /// <summary>
        /// async라는 키워드는 이 메소드가 비동기로 동작한다라는 것을 선언적으로 명시를 해주는 키워드
        /// async 키워드가 있으면 비동기로 동작한다고 생각하면 됨. 또한 async는 이 메서드 안에 await라는 키워드가 
        /// 존재하는걸 알려준다.
        /// await의 역할은 비동기로 동작하는 메서드가 작업을 모두 종료할때까지 대기하는 역할을 함.
        /// </summary>
        /// <returns></returns>
        private async void Test1()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            
            // 이것은 Sum()이라는 메서드의 작업 종료시까지 기다렸다가 작업이 완료되면 변수에 담아주는 역할을 함.
            // 결론적으로 await로 수식된 메서드가 종료되면 await를 만나기 전의 스레드로 동작하는 것을 await가 보장
            long sum = await Sum();
        }



        private async Task<long> Sum()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            
            long sum = 0;

            await Task.Factory.StartNew(() =>
            {
                
                for (int i = 0; i < 1000000000; i++)
                {
                    sum += i;
                }
            });
            return sum;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("비동기 단일 쓰레드");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            //델리게이트를 통해 다른 메서드를 전달 받지 않고  람다식으로 직접 수행하기 때문에 단일 스레드, 비동기로 실행
            await Task.Factory.StartNew(() =>
            {
                long sum = 0;
                for (int i = 0; i < 1000000000; i++)
                {
                    sum += i;
                }
            });
        }
    }
}
