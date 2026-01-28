using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project8
{
    internal class Shop : IEnumerable<Product>
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        private List<Product> products = new List<Product>();

        public Shop(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
