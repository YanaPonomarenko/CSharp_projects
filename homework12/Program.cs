namespace homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine();

            Console.Write("Enter magazine name: ");
            magazine.Title = Console.ReadLine();

            Console.Write("Enter publisher: ");
            magazine.Publisher = Console.ReadLine();

            Console.Write("Enter release date (yyyy-mm-dd): ");
            magazine.ReleaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter number of pages: ");
            magazine.Pages = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Magazine information:");
            PrintMagazine(magazine);

            string filePath = "magazine.json";

            MagazineStorage.SaveToFile(magazine, filePath);

            Magazine loadedMagazine = MagazineStorage.LoadFromFile(filePath);

            Console.WriteLine();
            Console.WriteLine("Data loaded from file:");
            PrintMagazine(loadedMagazine);

            Console.ReadLine();
        }

        static void PrintMagazine(Magazine magazine)
        {
            Console.WriteLine("Name: " + magazine.Title);
            Console.WriteLine("Publisher: " + magazine.Publisher);
            Console.WriteLine("Release date: " + magazine.ReleaseDate.ToShortDateString());
            Console.WriteLine("Pages: " + magazine.Pages);
        }

    }
}

