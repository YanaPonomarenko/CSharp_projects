using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework11
{
    public class MemoryAllocator : IDisposable
    {
        private List<string> data;
        private bool disposed;

        public MemoryAllocator(int capacity)
        {
            data = new List<string>(capacity);
        }

        public void AllocateMemory(int count)
        {
            for (int i = 0; i < count; i++)
            {
                TestObject obj = new TestObject
                {
                    Id = i,
                    Name = "Обєкт" + i,
                    Created = DateTime.Now
                };

                string json = $"{obj.Id}|{obj.Name}|{obj.Created}";
                data.Add(json);
            }
        }

        public void SimulateMemoryLoad()
        {
            for (int i = 0; i < data.Count; i += 2)
            {
                data[i] = null;
            }
        }

        public int GetGeneration()
        {
            return GC.GetGeneration(data);
        }

        public void ForceGarbageCollection()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                data = null;
            }

            disposed = true;
        }

        ~MemoryAllocator()
        {
            Dispose(false);
        }
    }
}

