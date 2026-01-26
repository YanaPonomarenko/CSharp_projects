namespace homework8._1
{
    internal class Program
    {
        public delegate int StringOperation(string text);

        static int CountVowels(string text)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (vowels.Contains(c))
                    count++;
            }

            return count;
        }

        static int CountConsonants(string text)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in text)
            {
                if (char.IsLetter(c) && !vowels.Contains(c))
                    count++;
            }

            return count;
        }

        static int GetLength(string text)
        {
            return text.Length;
        }

        static void Main(string[] args)
        {
            string words = "Banana mit Apfel";

            StringOperation operation;

            operation = CountVowels;
            Console.WriteLine("Vowels: " + operation(words));

            operation = CountConsonants;
            Console.WriteLine("Consonants: " + operation(words));

            operation = GetLength;
            Console.WriteLine("Length: " + operation(words));
        }
    }
}

