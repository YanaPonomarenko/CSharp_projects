using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project11
{
    internal class Person
    {
        private static int _nextId = 0;

        public int Id { get; }
        public string Name { get; set; }
        public short Age { get; set; }

        public Person()
        {
            Id = ++_nextId;
            Name = "default";
            Age = 0;
        }

        public Person(string name, short age)
        {
            Id = ++_nextId;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name}, Age: {Age}";
        }
    }
}

