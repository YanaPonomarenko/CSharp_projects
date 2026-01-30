namespace homework10
{
    class Play
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

        public Play(string title, string author, string genre, int releaseYear)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ReleaseYear = releaseYear;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Назва: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Жанр: " + Genre);
            Console.WriteLine("Рік випуску: " + ReleaseYear);
            Console.WriteLine();
        }

        ~Play()
        {
            Console.WriteLine("Деструктор викликано для: " + Title);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Play play1 = new Play(
            "Лісова пісня",
            "Леся Українка",
            "Драма",
            1911
            );

            Play play2 = new Play(
            "Каменярі",
            "Іван Франко",
            "Соціальна драма",
            1897
            );

            play1.ShowInfo();
            play2.ShowInfo();

            
            Console.WriteLine("тест деструктора");

            {
                Play tempPlay = new Play(
                    "Тимчасовий об'єкт",
                    "Тест Автор",
                    "Тест",
                    2000
                );
                tempPlay.ShowInfo();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

           
            for (int i = 0; i < 3; i++)
            {
                Play shortPlay = new Play(
                    $"П'єса {i + 1}",
                    $"Автор {i + 1}",
                    "Тест",
                    2020 + i
                );
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\n.");
        }
    }
}

