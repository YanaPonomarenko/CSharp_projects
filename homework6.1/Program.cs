namespace homework6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product("Apple", 20, 123.95m);
            Product peach = new Product("Peach", 32, 94.55m);
            Product grape = new Product("Grape", 18, 123.95m);

            apple += 5;  
            peach -= 10;

            Console.WriteLine(apple);   
            Console.WriteLine(peach);   
            Console.WriteLine(grape);  
            Console.WriteLine("\nPrice comparison:");
            Console.WriteLine($"Apple == Grape: {apple == grape}");  
            Console.WriteLine($"Apple != Peach: {apple != peach}");   

            Console.WriteLine("\nQuantity comparison:");
            Console.WriteLine($"Peach > Apple: {peach > apple}");      
            Console.WriteLine($"Grape < Apple: {grape < apple}");    
        }
    }
}
