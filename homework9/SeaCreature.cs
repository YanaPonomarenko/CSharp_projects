using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9
{
    public abstract class SeaCreature
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public abstract void DisplayInfo();
    }
}
