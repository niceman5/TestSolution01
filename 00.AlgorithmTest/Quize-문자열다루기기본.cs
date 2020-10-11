using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * 문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수, solution을 완성하세요. 
 * 예를 들어 s가 a234이면 False를 리턴하고 1234라면 True를 리턴하면 됩니다.

제한 사항
s는 길이 1 이상, 길이 8 이하인 문자열입니다.
입출력 예
s	return
a234	false
1234	true



public bool solution(string s) 
{
    bool answer = false;

    if(s.Length == 4 || s.Length == 6)
    {
        answer = Regex.IsMatch(s, @"^\d+$");
    }

    return answer;
}



 * 
 * */

namespace _00.AlgorithmTest
{
    class Quize_문자열다루기기본
    {
        private bool solution(string s)
        {
            int i;
            return (s.Length == 4 || s.Length == 6) && Int32.TryParse(s, out i);
        }
        public void Answer()
        {
            Console.WriteLine(solution("123").ToString());            
        }
    }
}
