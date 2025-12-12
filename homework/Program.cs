namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            //Console.Write("Введіть число: ");
            //double number = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Введіть відсоток: ");
            //double percent = Convert.ToDouble(Console.ReadLine());

            //double result = number * (percent / 100);
            //Console.WriteLine($"{percent}% від {number} = {result}");

            //5
            //Console.Write("Введіть дату (наприклад 22.12.2021): ");
            //string input = Console.ReadLine();

            //try
            //{
            //    DateTime date = DateTime.Parse(input);

            //    string season;
            //    int month = date.Month;
            //    if (month == 12 || month == 1 || month == 2) season = "Winter";
            //    else if (month >= 3 && month <= 5) season = "Spring";
            //    else if (month >= 6 && month <= 8) season = "Summer";
            //    else season = "Autumn";

            //    string dayName = date.DayOfWeek.ToString();

            //    Console.WriteLine($"{season} {dayName}");
            //}
            //catch
            //{
            //    Console.WriteLine("Невірний формат дати");
            //}


            //6
            //Console.WriteLine("Оберіть конвертацію:");
            //Console.WriteLine("1 - Фаренгейт в Цельсій");
            //Console.WriteLine("2 - Цельсій в Фаренгейт");
            //Console.Write("Ваш вибір: ");

            //int choice = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введіть температуру: ");
            //double temperature = Convert.ToDouble(Console.ReadLine());

            //if (choice == 1)
            //{
            //    double celsius = (temperature - 32) * 5 / 9;
            //    Console.WriteLine($"{temperature}°F = {celsius:F2}°C");
            //}
            //else if (choice == 2)
            //{
            //    double fahrenheit = (temperature * 9 / 5) + 32;
            //    Console.WriteLine($"{temperature}°C = {fahrenheit:F2}°F");
            //}
            //else
            //{
            //    Console.WriteLine("Невірний вибір");
            //}

            //3

            Console.WriteLine("Введіть чотири цифри:");

            int[] digits = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Цифра {i + 1}: ");
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }

            int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];
            Console.WriteLine($"Готове число: {number}");
        }
    }
}
