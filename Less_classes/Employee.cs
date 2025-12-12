using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_classes
{
    internal class Employee
    {
        public string Name {  get; set; }
        public int Age { get; set; }

        public int Salary
        {
            get { return Salary; }

            set
            {
                if (value < 0)
                    throw new ArgumentException("Error");
                Salary = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Employee: {Name}, {Age} age, salary {Salary}");
        }

    }
}
