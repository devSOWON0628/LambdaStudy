using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStudy
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>()
            {
                new Product(){Name="사과꽃", Price=100}
                ,new Product(){Name="안개꽃",Price=8000}
                ,new Product(){Name="장미꽃", Price=500}
                ,new Product(){Name="국화꽃", Price=343000}
                ,new Product(){Name="어쩌구",Price=140}
            };//new Product

            //정렬
            //Sort() 메서드의 매개변수로 람다를 지정합니다
            products.Sort((a, b) =>
            {
                return a.Price.CompareTo(b.Price);
            });

            //아래처럼 더 간단히 할 수도 있음
            products.Sort((a, b) => a.Price.CompareTo(b.Price));

            //출력
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + ":" + item.Price);
            }

        }
    }//Main()
}//class
