using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Shark : SeaCreature
    {
        public double Length { get; set; }

        public Shark(string name, int age, double length)
        {
            Name = name;
            Species = "Shark";
            Age = age;
            Length = length;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Species} '{Name}', Age: {Age}, Length: {Length}m");
        }
    }
}
