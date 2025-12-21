namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4
            Console.Write("Введіть розмір першого масиву (M): ");
            int M = int.Parse(Console.ReadLine());
            int[] array1 = new int[M];

            Console.WriteLine($"Введіть {M} елементів першого масиву:");
            for (int i = 0; i < M; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введіть розмір другого масиву (N): ");
            int N = int.Parse(Console.ReadLine());
            int[] array2 = new int[N];

            Console.WriteLine($"Введіть {N} елементів другого масиву:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array2[i] = int.Parse(Console.ReadLine());
            }

            int maxSize;
            if (M < N)
            {
                maxSize = M;
            }
            else
            {
                maxSize = N;
            }

            int[] temp = new int[maxSize];
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                bool foundArr2 = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        foundArr2 = true;
                        break;
                    }
                }
                if (foundArr2)
                {
                    bool uniqueEl = true;

                    for (int k = 0; k < count; k++)
                    {
                        if (temp[k] == array1[i])
                        {
                            uniqueEl = false;
                            break;
                        }
                    }

                    if (uniqueEl)
                    {
                        temp[count] = array1[i];
                        count++;
                    }
                }
            }

            int[] common = new int[count];
            for (int i = 0; i < count; i++)
            {
                common[i] = temp[i];
            }

            Console.WriteLine("\nСпільні елементи без повторень:");
            if (count == 0)
            {
                Console.WriteLine("Спільних елементів не знайдено");
            }
            else
            {
                for (int i = 0; i < common.Length; i++)
                {
                    Console.Write(common[i] + " ");
                }
            }

            //6
            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine();

            int wordCount = 0;
            bool word = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                char current = sentence[i];

                if (current != ' ' && current != '\t')
                {
                    if (!word)
                    {
                        wordCount++;
                        word = true;
                    }
                }
                else
                {
                    word = false;
                }
            }

            Console.WriteLine($"\nУ реченні: \"{sentence}\"");
            Console.WriteLine($"Кількість слів: {wordCount}");

            //7
            Console.Write("\nВведіть речення: ");
            string sentences = Console.ReadLine();
            bool words = false;
            int wordStart = 0;

            Console.Write("Результат: ");

            for (int i = 0; i <= sentence.Length; i++)
            {
                if (i < sentence.Length && sentence[i] != ' ' && !words)
                {
                    words = true;
                    wordStart = i;
                }
                else if (i == sentence.Length || sentence[i] == ' ')
                {
                    if (words)
                    {
                        int wordLength = i - wordStart;
                        char[] wordArray = new char[wordLength];

                        for (int j = 0; j < wordLength; j++)
                            wordArray[j] = sentence[wordStart + j];

                        for (int j = 0; j < wordLength / 2; j++)
                        {
                            char tempp = wordArray[j];
                            wordArray[j] = wordArray[wordLength - 1 - j];
                            wordArray[wordLength - 1 - j] = tempp;
                        }

                        Console.Write(new string(wordArray));

                        if (i != sentence.Length)
                            Console.Write(' ');

                        words = false;
                    }
                    else if (i < sentence.Length && sentence[i] == ' ')
                    {
                        Console.Write(' ');
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
