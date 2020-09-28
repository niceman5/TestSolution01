using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SortApp1
{
    // IntegerCompare 정렬에 필요한 동작을 구현함. IComparer 를 상속해서 구현
    class IntegerCompare : IComparer        // IComparer 를 상속
    {
        // 이 메서드는 Array.Sort메서드 내에서 호출됨 콜벡으로
        public int Compare(object x, object y)
        {
            int xValue = (int)x;
            int yValue = (int)y;

            if (xValue > yValue)
            {
                return -1;
            }
            else if (xValue == yValue )
            {
                return 0;
            }

            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            // IComparer를 상속받은 IntegerCompare 인스턴스 전달.
            Array.Sort(intArray, new IntegerCompare());

            foreach (var item in intArray)
            {
                Console.Write(item + ",");
            }
            Console.ReadLine();
        }
    }
}
