namespace homework3
{
    internal class Program
    {
        static void PrintSquare(int sideLength, char symbol)
        {
            Console.WriteLine("\nКвадрат:");
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }

            // Метод для перевірки паліндрому
            static bool Palindrome(int number)
            {
                int original = number;
                if (original < 0) original = -original;

                int reversed = 0;
                int temp = original;

                while (temp > 0)
                {
                    int digit = temp % 10;
                    reversed = reversed * 10 + digit;
                    temp = temp / 10;
                }

                return original == reversed;
            }

            // Метод для фільтрації масиву
            static int[] FilterArray(int[] originalArr, int[] filterArr)
            {
                int[] tempResult = new int[originalArr.Length];
                int count = 0;

                for (int i = 0; i < originalArr.Length; i++)
                {
                    bool remove = false;

                    for (int j = 0; j < filterArr.Length; j++)
                    {
                        if (originalArr[i] == filterArr[j])
                        {
                            remove = true;
                            break;
                        }
                    }
                    if (!remove)
                    {
                        tempResult[count] = originalArr[i];
                        count++;
                    }
                }
                int[] result = new int[count];
                for (int i = 0; i < count; i++)
                {
                    result[i] = tempResult[i];
                }

                return result;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Квадрат з символу");
                Console.Write("Введіть довжину сторони квадрата: ");
                int side = int.Parse(Console.ReadLine());

                Console.Write("Введіть символ для квадрата: ");
                char symbol = Console.ReadLine()[0];

                PrintSquare(side, symbol);

                Console.WriteLine("\n\nПеревірка паліндрому");
                Console.Write("Введіть число для перевірки: ");
                int number = int.Parse(Console.ReadLine());

                bool isPal = Palindrome(number);
                if (isPal)
                    Console.WriteLine($"Число {number} є паліндромом");
                else
                    Console.WriteLine($"Число {number} не є паліндромом");

                Console.WriteLine("\n\nФільтрація масиву");

                Console.Write("Введіть розмір першого масиву: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr1 = new int[n];

                Console.WriteLine("Введіть елементи першого масиву:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Елемент {i + 1}: ");
                    arr1[i] = int.Parse(Console.ReadLine());
                }

                Console.Write("\nВведіть розмір другого масиву: ");
                int m = int.Parse(Console.ReadLine());
                int[] arr2 = new int[m];

                Console.WriteLine("Введіть елементи другого масиву:");
                for (int i = 0; i < m; i++)
                {
                    Console.Write($"Елемент {i + 1}: ");
                    arr2[i] = int.Parse(Console.ReadLine());
                }

                int[] result = FilterArray(arr1, arr2);

                Console.Write("\nПерший масив: ");
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(arr1[i] + " ");
                }

                Console.Write("\nДругий масив: ");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write(arr2[i] + " ");
                }

                Console.Write("\nРезультат фільтрації: ");
                if (result.Length == 0)
                {
                    Console.WriteLine("(порожньо)");
                }
                else
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.Write(result[i] + " ");
                    }
                }
            }
        }
    }
}
