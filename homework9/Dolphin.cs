using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Dolphin : SeaCreature
    {
        public int IntelligenceLevel { get; set; }

        public Dolphin(string name, int age, int intelligenceLevel)
        {
            Name = name;
            Species = "Dolphin";
            Age = age;
            IntelligenceLevel = intelligenceLevel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Species} '{Name}', Age: {Age}, Intelligence: {IntelligenceLevel}/10");
        }
    }
}
