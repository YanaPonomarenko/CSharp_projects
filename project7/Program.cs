using System.Collections.Generic;
namespace project7
{
    class Pair<T1, T2>
    {
        private T1 a;
        private T2 b;

        public void Add(T1 value1, T2 value2)
        {
            a = value1;
            b = value2;
        }

        public void Display()
        {
            Console.WriteLine($"First: {a}");
            Console.WriteLine($"Second: {b}");
        }
         internal class Program
        {
            static void Main(string[] args)
            {
                Pair<string, int> p1 = new Pair<string, int>();
                p1.Add("bread", 30);
                p1.Display();
            }
        }
    }
}
