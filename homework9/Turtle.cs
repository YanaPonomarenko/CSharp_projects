using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public class Turtle : SeaCreature
    {
        public double ShellDiameter { get; set; }

        public Turtle(string name, int age, double shellDiameter)
        {
            Name = name;
            Species = "Turtle";
            Age = age;
            ShellDiameter = shellDiameter;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"{Species} '{Name}', Age: {Age}, Shell: {ShellDiameter}cm");
        }
    }
}
