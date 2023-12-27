public struct HockeyPlayer
{
    public string LastName;
    public int Age;
    public int GamesPlayed;
    public int GoalsScored;
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите количество хоккеистов: ");
        int count = int.Parse(Console.ReadLine());

        HockeyPlayer[] players = new HockeyPlayer[count];

        Console.WriteLine("Введите данные о хоккеистах:");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Хоккеист №" + (i + 1));
            Console.WriteLine("Фамилия: ");
            players[i].LastName = Console.ReadLine();

            Console.WriteLine("Возраст: ");
            players[i].Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество игр: ");
            players[i].GamesPlayed = int.Parse(Console.ReadLine());

            Console.WriteLine("Количество заброшенных шайб: ");
            players[i].GoalsScored = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }

        int totalAge = 0;
        int countUnder25 = 0;

        Console.WriteLine("Сведения о хоккеистах с возрастом меньше 25 лет:");

        foreach (HockeyPlayer player in players)
        {
            totalAge += player.Age;

            if (player.Age < 25)
            {
                Console.WriteLine("Фамилия: " + player.LastName);
                Console.WriteLine("Возраст: " + player.Age);
                Console.WriteLine("Количество игр: " + player.GamesPlayed);
                Console.WriteLine("Количество заброшенных шайб: " + player.GoalsScored);
                Console.WriteLine();
                countUnder25++;
            }
        }

        double averageAge = (double)totalAge / count;

        Console.WriteLine("Средний возраст хоккеистов: " + averageAge);
        Console.WriteLine("Количество хоккеистов с возрастом меньше 25 лет: " + countUnder25);
    }
}