namespace homework9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category<int> electronics = new Category<int>();

            electronics.Add(new Product<int>(
                "Electronics", "Laptop", 2100, DateTime.Now.AddDays(-10)));

            electronics.Add(new Product<int>(
                "Electronics", "Mouse", 65, DateTime.Now.AddDays(-40)));

            electronics.Add(new Product<int>(
                "Electronics", "Keyboard", 500, DateTime.Now.AddDays(-5)));

            Console.WriteLine("All products");
            foreach (var product in electronics)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nPrice from 100 to 500");
            foreach (var product in electronics.GetByPriceRange(100, 500))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nAdded in last 30 days");
            foreach (var product in electronics.GetAddedInLastDays(30))
            {
                Console.WriteLine(product);
            }
        }
    }
}
