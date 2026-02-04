namespace project13
{
    class Unit
    {
        private static int count = 0;
        private const int max_objects = 5;

        public Guid ID { get; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }

        public Unit(string name, int damage, int health)
        {
            if (count >= max_objects)
            {
                throw new InvalidOperationException("Не можна создати більше 5 обектів класа Unit.");
            }

            ID = Guid.NewGuid();
            Name = name;
            Damage = damage;
            Health = health;

            count++;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                try
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        Console.Write("Ведіть імя юніта: ");
                        string name = Console.ReadLine();

                        Console.Write("Ведіть урон: ");
                        int damage = int.Parse(Console.ReadLine());

                        Console.Write("Ведіть здоровье: ");
                        int health = int.Parse(Console.ReadLine());

                        Unit unit = new Unit(name, damage, health);
                        Console.WriteLine($"Зроблен: {unit.Name}, ID: {unit.ID}");
                        Console.WriteLine();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: Невірний формат введення для числа.");
                }
            }
        }
    }
}
