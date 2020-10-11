using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

/*
 * 문제 설명
1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수, solution을 만들어 보세요.

소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다.
(1은 소수가 아닙니다.)

제한 조건
n은 2이상 1000000이하의 자연수입니다.
입출력 예
n	result
10	4
5	3
입출력 예 설명
입출력 예 #1
1부터 10 사이의 소수는 [2,3,5,7] 4개가 존재하므로 4를 반환

입출력 예 #2
1부터 5 사이의 소수는 [2,3,5] 3개가 존재하므로 3를 반환


아래로직은 시간초과 남



 bool IsPrime(int num)
{
    for (int i = 2; i * i <= num ; i++)            
        if (num % i == 0)                
            return false;                            
    return true;
}
public int solution(int n)
{
    int answer = 0;

    for (int i = 2; i <= n; i++)            
        if (IsPrime(i))                
            answer++;
    return answer;
}

 * 
 * */

namespace _00.AlgorithmTest
{

    class Quize_소수찾기
    {
        /// <summary>
        /// 속도가 느림
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int solution(int n)
        {
            int ans = 0;
            int nCnt = 0;

            for (int i = 2; i <= n; i++)
            {
                nCnt = 1;            

                for (int j = 2; j <= i / 2  ; j++)
                {
                    if (i % j == 0)
                    {                                              
                        if (nCnt++ > 1)
                        {
                            break;
                        }
                    }                    
                }

                if (nCnt == 1)
                {
                    Console.WriteLine(i);
                    ans++;
                }                
            }

            //Console.WriteLine("------------------------------------------------");
            //foreach (int item in ans)
            //{
            //    Console.WriteLine(item); ;
            //}
            return ans;
        }

        /// <summary>
        /// 속도 개선판
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int solution2(int n)
        {
            List<int> list = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                list.Add(i);
            }

            for (int i = 2; i <= n; i++)
            {
                //list.RemoveAll(x => x > i && i % x == 0);
                list.RemoveAll(delegate (int x) { return x > i && x % i == 0; });
            
            }

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            return list.Count;
        }



        public void Answer()
        {
            Console.WriteLine(solution(100));
            Console.WriteLine(solution2(100));
        }
    }
}
