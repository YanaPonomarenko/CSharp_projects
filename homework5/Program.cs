namespace homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Ivan", 20, 1500);
            Employee emp2 = new Employee("Anna", 35, 6000);

            Console.WriteLine("Start:");
            emp1.Show();
            emp2.Show();

            emp1 = emp1 + 1000;
            Console.WriteLine("\nAfter +1000:");
            emp1.Show();

            emp2 = emp2 - 500;
            Console.WriteLine("After -500:");
            emp2.Show();

            Console.WriteLine($"\nemp1 == emp2: {emp1 == emp2}");
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}");
            Console.WriteLine($"emp1 > emp2: {emp1 > emp2}");
            Console.WriteLine($"emp1 < emp2: {emp1 < emp2}");
        }
    }
}
