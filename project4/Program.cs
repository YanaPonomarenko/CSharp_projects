namespace project4
{
    internal class Program
    {
        public delegate int MyDelegate(int a, int b);

        static void ProcessArray(int[] array, MyDelegate myDel)
        {
            if (array.Length == 0)
            {
                Console.WriteLine("Масив порожній");
                return;
            }

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = myDel(result, array[i]);
            }

            Console.WriteLine($"Результат {result}");
        }

        static int GetMin(int a, int b)
        {
            return a < b ? a : b;
        }

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static int GetSum(int a, int b)
        {
            return a + b;
        }

        static int GetProduct(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 4, 9 };

            Console.Write("Масив: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            MyDelegate myDel;

            myDel = GetMin;
            Console.Write("Мінімум: ");
            ProcessArray(numbers, myDel);

            myDel = GetMax;
            Console.Write("Максимум: ");
            ProcessArray(numbers, myDel);

            myDel = GetSum;
            Console.Write("Сума: ");
            ProcessArray(numbers, myDel);

            myDel = GetProduct;
            Console.Write("Добуток: ");
            ProcessArray(numbers, myDel);
        }
    }
}
