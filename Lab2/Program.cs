using Lab2;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Fruit> fruitsList = new List<Fruit>();

        for (int i = 0; i < 15; i++)
        {
            Fruit fruit = Fruit.Create();
            fruitsList.Add(fruit);
        }

        foreach (Fruit fruit in fruitsList)
        {
            //Console.WriteLine($"Nazwa: {fruit.Name}, Czy jest słodki: {fruit.IsSweet}, Cena: {fruit.Price}");
            Console.WriteLine(fruit.ToString());
        }
    }
}