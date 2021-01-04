using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using data = System.Collections.Generic.KeyValuePair<int, int>;

namespace _00.AlgorithmTest
{
    class Quize2_프린터
    {
        private int solution(int[] priorities, int location)
        {
            int answer = 0;
            

            var prt = new List<data>();

            for (int i = 0; i < priorities.Length; i++)
            {
                prt.Add( new data(priorities[i], i) );                
            }

            var slst = prt.OrderByDescending(x => x.Key).ThenBy(x => x.Value).ToList();

            //foreach (KeyValuePair<int,int> item in prt)
            //{
            //    Console.WriteLine($"[{item.Key}, {item.Value}]" );
            //}

            foreach (KeyValuePair<int, int> item in slst)
            {
                Console.WriteLine($"[{item.Key}, {item.Value}]");
            }
            Console.WriteLine(slst.Find(x => x.Key == priorities[location]));

            return answer;
        }

        public void Answer()
        {
            int res = solution(new int[] { 2,1,3,2 },2);
            //int[] res = solution(new int[] { 1,1,9,1,1,1 }, 0);
            
            Console.Write(res);
        }
    }
}
