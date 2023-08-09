using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    internal class Fruit
    {
        public string Name { get; set; }
        public bool IsSweet { get; set; }
        public double Price { get; set; }
        public double UsdPrice => Price / UsdCourse.Current;
        public static Fruit Create()
        {
            Random r = new Random();
            string[] names = new string[] { "Apple", "Banana","Cherry", "Durian", "Edelberry", "Grape", "Jackfruit" };
            return new Fruit
            {
                Name = names[r.Next(names.Length)],
                IsSweet = r.NextDouble() > 0.5,
                Price = r.NextDouble() * 10
            };
        }

        override public string ToString()
        {
            string formattedPrice = MyFormatter.FormatUsdPrice(UsdPrice);
            return $"Nazwa: {Name}, Czy jest słodki: {IsSweet}, Cena w zł: {Price.ToString("C2")}, Cena w USD: {formattedPrice}";
        }
    }

}

