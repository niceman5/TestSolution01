using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// this string s 확장하려는 class type, 뒤는 매개변수
        /// </summary>
        /// <param name="s"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToPlus(this string s, string b)
        {
            return s + b;
        }
    }
}
