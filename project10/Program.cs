using System;
using System.Diagnostics;

namespace project10
{
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }
    }

    class MemoryAllocator : IDisposable
    {
        private Car[] cars;

        public MemoryAllocator(int size)
        {
            cars = new Car[size];
            for (int i = 0; i < size; i++)
            {
                cars[i] = new Car("Audi", 2020);
            }
        }

        public void SimulateMemoryLoad(int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Car temp = new Car("Mercedez", 2000);
            }
        }

        public void PrintGeneration()
        {
            Console.WriteLine(GC.GetGeneration(cars[0]));
        }

        public void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // 
            }
        }

        ~MemoryAllocator()
        {
            Dispose(false);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            using (MemoryAllocator allocator = new MemoryAllocator(1_000_000))
            {
                allocator.PrintGeneration();

                allocator.SimulateMemoryLoad(500_000);

                Console.WriteLine(GC.GetTotalMemory(false));

                allocator.ForceGC();

                allocator.PrintGeneration();

                Console.WriteLine(GC.GetTotalMemory(true));
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            using (MemoryAllocator allocator2 = new MemoryAllocator(10000))
            {
                allocator2.PrintGeneration();
                allocator2.SimulateMemoryLoad(10000);
                allocator2.ForceGC();
                allocator2.PrintGeneration();
            }
        }
    }
}
