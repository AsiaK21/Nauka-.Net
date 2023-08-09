//zadanie 1.3
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 100; i++)
//        {
//            if (i % 3 == 0 && i % 5 == 0)
//            {
//                Console.WriteLine("FizzBuzz");
//            }
//            else if (i % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (i % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//zadanie 1.4 i 1.5 i 1.6
using Lab1;
using System.Text.Json;
using System.Text.Json;

class Program
{
    static void Main()
    {
        var rand = new Random();
        var value = rand.Next(1, 101);
        int liczba;
        int próba = 0;

        Console.WriteLine("Zgadnij liczbę z zakresu od 1 do 100.");

        do
        {
            Console.Write("Podaj swoją liczbę: ");
            liczba = Convert.ToInt32(Console.ReadLine());
            próba++;

            if (liczba < value)
            {
                Console.WriteLine("Ta liczba jest mniejsza niż wygenerowana.");
            }
            else if (liczba > value)
            {
                Console.WriteLine("Ta liczba jest większa niż wygenerowana.");
            }
            else
            {
                Console.WriteLine("Brawo, to ta liczba");

                Console.Write("Podaj swoje imię: ");
                string name = Console.ReadLine();

                Console.WriteLine("Liczba prób: " + próba);
                var hs = new HighScore { Name = name, Trials = próba };

                List<HighScore> highScores;
                const string FileName = "highscores.json";
                if (File.Exists(FileName))
                    highScores = JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FileName));
                else
                    highScores = new List<HighScore>();

                highScores.Add(hs);

                highScores.Sort((x, y) => x.Trials.CompareTo(y.Trials));

                File.WriteAllText(FileName, JsonSerializer.Serialize(highScores));

                foreach (var item in highScores)
                {
                    Console.WriteLine($"{item.Name} -- {item.Trials} prób");
                }
            }

        } while (liczba != value);
    }
}
