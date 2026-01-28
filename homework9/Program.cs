namespace homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oceanarium oceanarium = new Oceanarium("Oceanarium", "Odesa");

            oceanarium.AddCreature(new Dolphin("Flipper", 5, 8));
            oceanarium.AddCreature(new Shark("Jaws", 12, 4.5));
            oceanarium.AddCreature(new Turtle("Shelly", 25, 40));

            foreach (SeaCreature creature in oceanarium)
            {
                creature.DisplayInfo();
            }
        }
    }
}
