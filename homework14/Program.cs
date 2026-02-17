namespace homework14
{
    internal class Program
    {
        abstract class Continent
        {
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        }

        class Africa : Continent
        {
            public override Herbivore CreateHerbivore()
            {
                return new Wildebeest();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Lion();
            }
        }

        class NorthAmerica : Continent
        {
            public override Herbivore CreateHerbivore()
            {
                return new Bison();
            }

            public override Carnivore CreateCarnivore()
            {
                return new Wolf();
            }
        }

        abstract class Herbivore
        {
            public int Weight { get; set; }
            public bool Life { get; set; } = true;
            public abstract void EatGrass();
        }

        class Wildebeest : Herbivore
        {
            public Wildebeest()
            {
                Weight = 100;
            }

            public override void EatGrass()
            {
                if (Life)
                {
                    Weight += 10;
                    Console.WriteLine("Антилопа Гну їсть траву. Вага збільшилась до " + Weight);
                }
            }
        }

        class Bison : Herbivore
        {
            public Bison()
            {
                Weight = 120;
            }

            public override void EatGrass()
            {
                if (Life)
                {
                    Weight += 10;
                    Console.WriteLine("Бізон їсть траву. Вага збільшилась до " + Weight);
                }
            }
        }

        abstract class Carnivore
        {
            public int Power { get; set; }
            public abstract void Eat(Herbivore herbivore);
        }

        class Lion : Carnivore
        {
            public Lion()
            {
                Power = 110;
            }

            public override void Eat(Herbivore herbivore)
            {
                if (!herbivore.Life)
                {
                    Console.WriteLine("Лев намагається їсти, але травоїдна вже мертва");
                    return;
                }

                Console.WriteLine($"Лев (сила {Power}) нападає на травоїдну (вага {herbivore.Weight})");

                if (Power > herbivore.Weight)
                {
                    Power += 10;
                    herbivore.Life = false;
                    Console.WriteLine($"Лев переміг! Сила збільшилась до {Power}");
                }
                else
                {
                    Power -= 10;
                    Console.WriteLine($"Лев програв... Сила зменшилась до {Power}");
                }
            }
        }

        class Wolf : Carnivore
        {
            public Wolf()
            {
                Power = 105;
            }

            public override void Eat(Herbivore herbivore)
            {
                if (!herbivore.Life)
                {
                    Console.WriteLine("Вовк намагається їсти, але травоїдна вже мертва");
                    return;
                }

                Console.WriteLine($"Вовк (сила {Power}) нападає на травоїдну (вага {herbivore.Weight})");

                if (Power > herbivore.Weight)
                {
                    Power += 10;
                    herbivore.Life = false;
                    Console.WriteLine($"Вовк переміг! Сила збільшилась до {Power}");
                }
                else
                {
                    Power -= 10;
                    Console.WriteLine($"Вовк програв... Сила зменшилась до {Power}");
                }
            }
        }

        class AnimalWorld
        {
            private List<Herbivore> herbivores = new List<Herbivore>();
            private List<Carnivore> carnivores = new List<Carnivore>();
            private Random random = new Random();

            public AnimalWorld(Continent continent, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    herbivores.Add(continent.CreateHerbivore());
                    carnivores.Add(continent.CreateCarnivore());
                }
            }

            public void MealsHerbivores()
            {
                Console.WriteLine("\nГодування травоїдних");
                foreach (var h in herbivores)
                {
                    h.EatGrass();
                }
            }

            public void NutritionCarnivores()
            {
                Console.WriteLine("\nПолювання хижаків");

                foreach (var carnivore in carnivores)
                {
                    var aliveHerbivores = herbivores.Where(h => h.Life).ToList();

                    if (aliveHerbivores.Count == 0)
                    {
                        Console.WriteLine("Немає живих травоїдних для полювання");
                        break;
                    }
                    int index = random.Next(aliveHerbivores.Count);
                    var targetHerbivore = aliveHerbivores[index];

                    carnivore.Eat(targetHerbivore);
                }
            }

            public void ShowState()
            {
                Console.WriteLine("\nСтан тварин");

                for (int i = 0; i < herbivores.Count; i++)
                {
                    string lifeStatus = herbivores[i].Life ? "Живий" : "Мертвий";
                    Console.WriteLine($"Травоїдна {i + 1}: {herbivores[i].GetType().Name}, Вага={herbivores[i].Weight}, Статус={lifeStatus}");
                }

                for (int i = 0; i < carnivores.Count; i++)
                {
                    Console.WriteLine($"Хижак {i + 1}: {carnivores[i].GetType().Name}, Сила={carnivores[i].Power}");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("   Симуляція життя в Африці  ");
            AnimalWorld africa = new AnimalWorld(new Africa(), 3);
            africa.MealsHerbivores();
            africa.NutritionCarnivores();
            africa.ShowState();

            Console.WriteLine("\n   Симуляція життя в Північній Америці   ");
            AnimalWorld america = new AnimalWorld(new NorthAmerica(), 3);
            america.MealsHerbivores();
            america.NutritionCarnivores();
            america.ShowState();
        }
    }
}

