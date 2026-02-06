namespace homework13
{
    internal class Program
    {
        class Phone
        {
            public string Name { get; set; }
            public string Manufacturer { get; set; }
            public decimal Price { get; set; }
            public DateTime ReleaseDate { get; set; }
        }

        static void Main(string[] args)
        {
            Phone[] phones = new Phone[]
         {
            new Phone { Name = "iPhone 15 Pro", Manufacturer = "Apple", Price = 1099, ReleaseDate = new DateTime(2023, 9, 22) },
            new Phone { Name = "Galaxy S24 Ultra", Manufacturer = "Samsung", Price = 1299, ReleaseDate = new DateTime(2024, 1, 31) },
            new Phone { Name = "Pixel 8 Pro", Manufacturer = "Google", Price = 999, ReleaseDate = new DateTime(2023, 10, 12) },
            new Phone { Name = "Xiaomi 13T Pro", Manufacturer = "Xiaomi", Price = 799, ReleaseDate = new DateTime(2023, 9, 26) },
            new Phone { Name = "OnePlus 11", Manufacturer = "OnePlus", Price = 699, ReleaseDate = new DateTime(2023, 2, 7) }
         };

            int totalPhones = phones.Count();
            int phonesOver100 = phones.Count(p => p.Price > 100);
            int phonesInRange = phones.Count(p => p.Price >= 400 && p.Price <= 700);
            int specificManufacturer = phones.Count(p => p.Manufacturer == "Apple");

            Phone minPricePhone = phones.OrderBy(p => p.Price).First();
            Phone maxPricePhone = phones.OrderByDescending(p => p.Price).First();
            Phone oldestPhone = phones.OrderBy(p => p.ReleaseDate).First();
            Phone newestPhone = phones.OrderByDescending(p => p.ReleaseDate).First();
            decimal averagePrice = phones.Average(p => p.Price);

            Console.WriteLine($"Total phones: {totalPhones}");
            Console.WriteLine($"Phones over $100: {phonesOver100}");
            Console.WriteLine($"Phones priced between $400 and $700: {phonesInRange}");
            Console.WriteLine($"Phones by Apple: {specificManufacturer}");
            Console.WriteLine($"Phone with minimum price: {minPricePhone.Name}, ${minPricePhone.Price}");
            Console.WriteLine($"Phone with maximum price: {maxPricePhone.Name}, ${maxPricePhone.Price}");
            Console.WriteLine($"Oldest phone: {oldestPhone.Name}, released on {oldestPhone.ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Newest phone: {newestPhone.Name}, released on {newestPhone.ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Average price: ${averagePrice}");
        }
    }
}

