namespace project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("ATB", "Odesa");

            shop.AddProduct(new Product("Bread", 40));
            shop.AddProduct(new Product("Potato", 65));
            shop.AddProduct(new Product("Apple", 70));

            foreach (Product product in shop)
            {
                Console.WriteLine(product);
            }
        }
    }
}
