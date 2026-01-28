using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Oceanarium : IEnumerable<SeaCreature>
    {
        private List<SeaCreature> creatures = new List<SeaCreature>();
        public string Name { get; set; }
        public string Location { get; set; }

        public Oceanarium(string name, string location)
        {
            Name = name;
            Location = location;
        }

        public void AddCreature(SeaCreature creature)
        {
            creatures.Add(creature);
        }

        public IEnumerator<SeaCreature> GetEnumerator()
        {
            return creatures.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void DisplayAllCreatures()
        {
            Console.WriteLine($"{Name} Oceanarium ({Location})");
            Console.WriteLine($"Total creatures: {creatures.Count}");

            foreach (var creature in creatures)
            {
                creature.DisplayInfo();
            }
        }
    }
}
