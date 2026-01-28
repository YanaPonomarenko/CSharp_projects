using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9._1
{
    public class Product<T>
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public T Price { get; set; }
        public DateTime DateAdded { get; set; }

        public Product(string category, string name, T price, DateTime dateAdded)
        {
            Category = category;
            Name = name;
            Price = price;
            DateAdded = dateAdded;
        }

        public override string ToString()
        {
            return $"{Category} - {Name}: {Price}, Added: {DateAdded:dd.MM.yyyy}";
        }
    }
}
