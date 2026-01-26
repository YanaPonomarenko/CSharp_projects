using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6._1
{
    internal class Product
    {
        public string Name { get; set; }

        private int quantity;
        private decimal price;

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative");
                quantity = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative");
                price = value;
            }
        }

        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product product, int amount)
        {
            return new Product(product.Name, product.Quantity + amount, product.Price);
        }

        public static Product operator -(Product product, int amount)
        {
            return new Product(product.Name, product.Quantity - amount, product.Price);
        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Product p1, Product p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentNullException("Cannot compare null products");
            return p1.Quantity > p2.Quantity;
        }

        public static bool operator <(Product p1, Product p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentNullException("Cannot compare null products");
            return p1.Quantity < p2.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product other)
                return Name == other.Name && Quantity == other.Quantity && Price == other.Price;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Quantity, Price);
        }

        public override string ToString()
        {
            return $"{Name}: Quantity = {Quantity}, Price = {Price:F2}";
        }
    }
}

