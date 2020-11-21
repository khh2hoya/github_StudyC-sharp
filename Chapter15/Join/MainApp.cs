using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }

        public int Height { get; set; }
    }

    class Product
    {
        public string Star { get; set; }
        public string Title { get; set; }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){ Name = "정우성", Height = 186 },
                new Profile(){ Name = "김태희", Height = 158 },
                new Profile(){ Name = "고현정", Height = 172 },
                new Profile(){ Name = "이문세", Height = 178 },
                new Profile(){ Name = "하하", Height = 171 }
            };

            Product[] arrProduct =
            {
                new Product(){ Star = "정우성" , Title ="비트" },
                new Product(){ Star = "김태희" , Title ="CF 다수" },
                new Product(){ Star = "김태희" , Title ="아이리스" },
                new Product(){ Star = "고현정" , Title ="모래시계" },
                new Product(){ Star = "이문세" , Title ="Solo 예찬" }
            };

            var listProfile = from profile in arrProfile
                              join product in arrProduct on profile.Name equals product.Star
                              select new
                              {
                                  Name = profile.Name,
                                  Height = profile.Height,
                                  Work = product.Title
                              };
            Console.WriteLine("내부조인 결과");
            foreach( var profile in listProfile )
            {
                Console.WriteLine("이름:{0}. 작품:{1}, 키:{2}", profile.Name, profile.Work, profile.Height);
            }

            
            listProfile = from profile in arrProfile
                               join product in arrProduct on profile.Name equals product.Star into ps
                               from product in ps.DefaultIfEmpty(new Product() { Title = "그런거 없음" })
                               select new
                               {
                                   Name = profile.Name,
                                   Height = profile.Height,
                                   Work = product.Title
                               };

            Console.WriteLine("외부조인 결과");

            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}", profile.Name, profile.Work, profile.Height);
            }

                       
        }
    }
}
