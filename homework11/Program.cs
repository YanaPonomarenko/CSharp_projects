using System.Diagnostics;

namespace homework11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест для виділення памяті\n");

            Console.WriteLine("Тест 1");
            RunTest(100000);

            Console.WriteLine("\nТест 2");
            RunTest(500000);

            Console.WriteLine("\nТест 3");
            RunTest(1000000);           

            Console.WriteLine("\nЗавершено");
        }

        static void RunTest(int count)
        {
            Stopwatch stopwatch = new Stopwatch();

            using (MemoryAllocator allocator = new MemoryAllocator(count))
            {
                stopwatch.Start();
                allocator.AllocateMemory(count);
                stopwatch.Stop();

                Console.WriteLine($"Час виділення пвмяті {stopwatch.ElapsedMilliseconds} мс");
                Console.WriteLine($"Покоління до GC: {allocator.GetGeneration()}");

                allocator.SimulateMemoryLoad();

                stopwatch.Restart();
                allocator.ForceGarbageCollection();
                stopwatch.Stop();

                Console.WriteLine($"GC час: {stopwatch.ElapsedMilliseconds} мс");
                Console.WriteLine($"Покоління після GC: {allocator.GetGeneration()}");

                Console.WriteLine($"Загальна память: {GC.GetTotalMemory(false) / 1024 / 1024} МБ");
            }
        }

    }
}
    

