using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.ConsoleTest
{

    internal class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class _06LinqTest02
    {   
        public void Run() 
        {
            Profile[] arrProfile = {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            Product[] arrProduct = {
                new Product() { Title="비트", Star="정우성" },
                new Product() { Title="CF다수", Star="김태희" },
                new Product() { Title="아이리스", Star="김태희" },
                new Product() { Title="모래시계", Star="고현정" },
                new Product() { Title="Solo예찬", Star="이문세" }
            };


            // inner join
            var listProfile = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star
                              select new
                              {
                                Name = profile.Name,
                                Work = product.Title,
                                Height = profile.Height
                              };

            Console.WriteLine("------ inner join ------");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name} 작품 : {profile.Work} 키 : {profile.Height}");
            }

            // outer join
            listProfile = from profile in arrProfile
                          join product in arrProduct on profile.Name equals product.Star into ps
                          from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })
                          select new
                          {
                            Name = profile.Name,
                            Work = product.Title,
                            Height = profile.Height
                          };
            Console.WriteLine();
            Console.WriteLine("------outer join------");
            foreach (var profile in listProfile)
            {
                Console.WriteLine($"이름 : {profile.Name} 작품 : {profile.Work} 키 : {profile.Height}");
            }


            // linq 메소드 테스트
            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 175 into g
                             select new
                             {
                                Group = (g.Key == true) ? "175미만":"175이상",
                                Count = g.Count(),
                                Max = g.Max(profile => profile.Height),
                                Min = g.Min(profile => profile.Height),
                                Avg = g.Average(profile => profile.Height)
                             };
            foreach (var stat in heightStat)
            {
                Console.WriteLine($"{stat.Group} - Count:{stat.Count} Max:{stat.Max} Min:{stat.Min} Avg:{stat.Avg}");
            }
        }
    }
}
