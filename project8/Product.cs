using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    internal class Product : IComparable<Product>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price}, ID: {Id}";
        }

        //практика за 12.01
        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
    }
}
