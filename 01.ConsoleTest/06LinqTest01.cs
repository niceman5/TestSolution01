using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ConsoleTest
{
    internal class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }
    
    internal class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class _06LinqTest01
    {
        public void Run()
        {
            Profile[] arrProfile = {
                new Profile(){Name="가가가1", Height=186},
                new Profile(){Name="가가가2", Height=158},
                new Profile(){Name="가가가3", Height=172},
                new Profile(){Name="가가가4", Height=178},
                new Profile(){Name="가가가5", Height=171}
            };


            // 일반적인 linq
            var p = from profile in arrProfile
                    where profile.Height < 175
                    orderby profile.Height descending
                    select new
                    {
                        Name = profile.Name,
                        Inch = profile.Height * 0.393
                    };

            foreach (var item in p)
            {
                Console.WriteLine($"{item.Name} {item.Inch}");
            }

            // 중첩데이터 처리 데이터의 속한 데이터 처리
            Class[] arrClass = {
                new Class(){Name="빨강반", Score=new int[]{99,80,70,24}},
                new Class(){Name="노랑반", Score=new int[]{60,45,87,72}},
                new Class(){Name="파랑반", Score=new int[]{98,72,45,88}},
                new Class(){Name="연두반", Score=new int[]{70,88,66,98}}
            };
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s ascending
                          select new { c.Name, Lowest = s };

            foreach (var c in classes)
            {
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
            }

            // group by 처리
            var listProfile = from profile in arrProfile
                              orderby profile.Height ascending
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, profile = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($" -175cm 미만? : {Group.GroupKey}");
                foreach (var profile in Group.profile)
                {
                    Console.WriteLine($"     {profile.Name}, {profile.Height}");
                }
            }                            



        }
    }


}
