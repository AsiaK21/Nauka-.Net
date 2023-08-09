using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static async Task Main()
        {
            UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();
            List<Fruit> fruitsList = new List<Fruit>();

            for (int i = 0; i < 15; i++)
            {
                Fruit fruit = Fruit.Create();
                fruitsList.Add(fruit);
            }

            var sweetFruits = fruitsList.Where(fruit => fruit.IsSweet).OrderByDescending(fruit => fruit.Price);

            foreach (Fruit fruit in sweetFruits)
            {
                Console.WriteLine(fruit.ToString());
            }
        }
    }
}
