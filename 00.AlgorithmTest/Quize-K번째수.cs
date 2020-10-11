﻿using System;
using System.Collections.Generic;
using System.Text;

/*

배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.

예를 들어 array가 [1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면

array의 2번째부터 5번째까지 자르면 [5, 2, 6, 3]입니다.
1에서 나온 배열을 정렬하면 [2, 3, 5, 6]입니다.
2에서 나온 배열의 3번째 숫자는 5입니다.
배열 array, [i, j, k]를 원소로 가진 2차원 배열 commands가 매개변수로 주어질 때, commands의 모든 원소에 대해 앞서 설명한 연산을 적용했을 때 나온 결과를 배열에 담아 return 하도록 solution 함수를 작성해주세요.

제한사항
array의 길이는 1 이상 100 이하입니다.
array의 각 원소는 1 이상 100 이하입니다.
commands의 길이는 1 이상 50 이하입니다.
commands의 각 원소는 길이가 3입니다.
입출력 예
array	commands	return
[1, 5, 2, 6, 3, 7, 4]	[[2, 5, 3], [4, 4, 1], [1, 7, 3]]	[5, 6, 3]
입출력 예 설명
[1, 5, 2, 6, 3, 7, 4]를 2번째부터 5번째까지 자른 후 정렬합니다. [2, 3, 5, 6]의 세 번째 숫자는 5입니다.
[1, 5, 2, 6, 3, 7, 4]를 4번째부터 4번째까지 자른 후 정렬합니다. [6]의 첫 번째 숫자는 6입니다.
[1, 5, 2, 6, 3, 7, 4]를 1번째부터 7번째까지 자릅니다. [1, 2, 3, 4, 5, 6, 7]의 세 번째 숫자는 3입니다.


public int[] solution(int[] array, int[,] commands) 
{
    int[] answer = new int[commands.GetLength(0)];
    List<int> lst = new List<int>(array);
    for (int i = 0; i < commands.GetLength(0); i++)
    {
        int nStart = commands[i, 0];
        int nEnd = commands[i, 1];
        int nIndex = commands[i, 2];
        List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
        answer[i] = lstSub[nIndex - 1];
    }
    return answer;
}
 */


namespace _00.AlgorithmTest
{ 
    class Quize_K번째수
    {
        public int[] solution(int[] array, int[,] commands)
        {
            List<int> answerList = new List<int>();

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < commands.GetLength(0); i++)
            //{
            //    for (int j = 0; j < commands.GetLength(1); j++)
            //    {
            //        // Console.WriteLine(string.Format("[{0},{1}] : {2}", i, j, commands[i, j]));            
            //    }
            //}
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int[] aRes = new int[(commands[i, 1] - commands[i, 0]) + 1];
                
                
                //Array.Copy(배열A, 0, 배열B, 2, 3)
                //배열 A의 0번째 값부터 3개를 배열 B, 2번째부터 복사

                Array.Copy(array, commands[i,0]-1, aRes, 0, (commands[i,1] - commands[i, 0])+1);
                Array.Sort(aRes);
                answerList.Add( aRes[commands[i, 2]-1]);
            }                

            return answerList.ToArray();
        }

        public void Answer()
        {            
            int[] res = solution(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 }});

            foreach (var item in res)
            {
                Console.Write(item.ToString() + ",");
            }
        }
    }
}
