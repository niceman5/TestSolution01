using System;
using System.Collections.Generic;
using System.Text;

namespace _00.AlgorithmTest
{
    class Quize_두정수사이의합
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }


        public long solution(int a, int b)
        {
            long answer = 0;

            if (a > b)
            {
                Swap(ref a, ref b);
            }

            for (int i = a; i <= b; i++)
            {
                answer += i;
            }

            return answer;
        }

        public void Answer()
        {
            Console.WriteLine(solution(5, 3));
        }
    }
}
