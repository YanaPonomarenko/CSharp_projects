namespace homework8
{
    internal class Program
    {
        public delegate bool NumberFilter(int number);

        static int[] FilterArray(int[] array, NumberFilter filter)
        {
            List<int> result = new List<int>();

            foreach (int number in array)
            {
                if (filter(number))
                    result.Add(number);
            }

            return result.ToArray();
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static bool IsFibonacci(int number)
        {
            if (number < 0)
            {
                return false;
            }

            if (number == 0 || number == 1)
            {
                return true;
            }

            int a = 0;
            int b = 1;

            while (b <= number)
            {
                int next = a + b;

                if (next == number)
                {
                    return true;
                }

                a = b;
                b = next;
            }
            return false;
        }

        static void PrintArray(string title, int[] array)
        {
            {
                Console.Write(title + ": ");

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);

                    if (i < array.Length - 1)
                    {
                        Console.Write(" ");
                    }
                }
            }

            static void Main(string[] args)
            {
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 13, 21, 22 };

                PrintArray("Even", FilterArray(numbers, IsEven));
                PrintArray("Odd", FilterArray(numbers, IsOdd));
                PrintArray("Prime", FilterArray(numbers, IsPrime));
                PrintArray("Fibonacci", FilterArray(numbers, IsFibonacci));
            }
        }
    }
}