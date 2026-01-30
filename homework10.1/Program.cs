namespace homework10._1
{
    enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

        private bool disposed = false;

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Назва магазину: " + Name);
            Console.WriteLine("Адреса: " + Address);
            Console.WriteLine("Тип: " + Type);
            Console.WriteLine();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose: звільнення ресурсів для " + Name);
                }
                disposed = true;
            }
        }

        ~Store()
        {
            Console.WriteLine("Деструктор для магазину: " + Name);
            Dispose(false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store("АТБ", "вул. Левітана 10", StoreType.Grocery);
            store1.ShowInfo();
            store1.Dispose();

            Console.WriteLine("---");

            using (Store store2 = new Store("Епіцентр", "вул. Небесної Сотні", StoreType.Household))
            {
                store2.ShowInfo();
            }

            Console.WriteLine("---");

            Store store3 = new Store("Zara", "ТРЦ Ocean Plaza", StoreType.Clothing);
            store3.ShowInfo();

            Console.WriteLine("---");

            using (Store store4 = new Store("Vito Rossi", "ТРЦ Lavina", StoreType.Footwear))
            {
                store4.ShowInfo();
            }

            Console.WriteLine(".");
        }
    }
}

