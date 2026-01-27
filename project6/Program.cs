namespace project6
{
    internal static class StringExtensions
    {
        public static int GetVowels(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            int count = 0;

            foreach (char c in text)
            {
                if (Array.IndexOf(vowels, c) != -1)
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            string normalized = text.ToLower().Replace(" ", "");

            int left = 0;
            int right = normalized.Length - 1;

            while (left < right)
            {
                if (normalized[left] != normalized[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "Level";
            string word3 = "Test";

            Console.WriteLine($"{word1}: голосних - {word1.GetVowels()}, паліндром - {word1.IsPalindrome()}");
            Console.WriteLine($"{word2}: голосних - {word2.GetVowels()}, паліндром - {word2.IsPalindrome()}");
            Console.WriteLine($"{word3}: голосних - {word3.GetVowels()}, паліндром - {word3.IsPalindrome()}");
        }    
    }
}

