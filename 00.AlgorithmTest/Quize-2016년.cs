using System;
using System.Collections.Generic;
using System.Text;

/*
문제 설명
2016년 1월 1일은 금요일입니다. 2016년 a월 b일은 무슨 요일일까요? 두 수 a , b를 입력받아 2016년 a월 b일이 무슨 요일인지 리턴하는 함수, 

solution을 완성하세요. 요일의 이름은 일요일부터 토요일까지 각각 SUN, MON, TUE, WED, THU, FRI, SAT 입니다. 

예를 들어 a=5, b = 24라면 5월 24일은 화요일이므로 문자열 TUE를 반환하세요.

제한 조건
2016년은 윤년입니다.
2016년 a월 b일은 실제로 있는 날입니다. (13월 26일이나 2월 45일같은 날짜는 주어지지 않습니다)

입출력 예
a	b	result
5	24	TUE


public string solution(int a, int b) {
    string answer = "";

        DateTime dateValue = new DateTime(2016,a,b);
        answer = dateValue.DayOfWeek.ToString().Substring(0,3).ToUpper();

        return answer;
}

*/

namespace _00.AlgorithmTest
{
    class Quize_2016년
    {
        private string solution(int a, int b)
        {
            string answer = "";
            Dictionary<int, string> dicDays = new Dictionary<int, string>();
            dicDays.Add(0, "SUN");
            dicDays.Add(1, "MON");
            dicDays.Add(2, "TUE");
            dicDays.Add(3, "WED");
            dicDays.Add(4, "THU");
            dicDays.Add(5, "FRI");
            dicDays.Add(6, "SAT");

            DateTime strtDt = Convert.ToDateTime("2016-01-01");
            DateTime endDt = Convert.ToDateTime(string.Format("2016-{0:00}-{1:00}", a, b));
            
            TimeSpan dateDiff = endDt - strtDt;            
            int diffDay = dateDiff.Days + 5;

            Console.WriteLine(strtDt);
            Console.WriteLine(endDt);
            Console.WriteLine(diffDay);
            dicDays.TryGetValue(diffDay % 7, out answer);

            return answer;
        }

        public void Answer()
        {
            Console.WriteLine(solution(5,24));
        }
    }
}
