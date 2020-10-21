using System;
using System.Collections.Generic;
using System.Text;

/*
 * 문제 설명
단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

재한사항
s는 길이가 1 이상, 100이하인 스트링입니다.
입출력 예
s	return
abcde	c
qwer	we
 * 
 * 
 * */

namespace _00.AlgorithmTest
{
    class Quize_가운데글자가져오기
    {
        public string solution(string s)
        {            
            int iPos = 0;
            int iLen = 0;

            if (s.Length % 2 == 0)
            {
                iLen = 2;
                iPos = s.Length / 2 - 1;
            }
            else
            {
                iLen = 1;
                iPos = s.Length / 2;
            }

            return s.Substring(iPos, iLen);
        }

        public void Answer()
        {
            Console.WriteLine(solution("qwer"));
        }
        
    }
}
