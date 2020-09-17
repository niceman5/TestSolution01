using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLinq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] strs = new string[5] { "a", "b", "c", "d", "e"};

            // IEnumerable 순서를 가지고 있는 인터페이스
            IEnumerable<int> even = from num in nums
                                    where (num % 2 == 0)
                                    select num;

            foreach (int num in even)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------------------");

            // var는 결과가 익명 형식이 되도록 할때 사용할수 있는 암시적 형식 지역변수
            var odd = nums.Where(o => o % 2 == 1);
            foreach (var num in odd)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------------------");


            // 아래의 형식은 실제 전체 루프돌리면서 if문으로 비교해서 return하는 메서드를 대체 한다.
            // 하나의 메서드 구현이 한줄로 끝남.......람다와 linq의 장점임..
            var str = strs.Where(o => o.Equals("a")).Select(o => o + "b");
            foreach (var s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}
