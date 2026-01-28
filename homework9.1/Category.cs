using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework9._1
{
    public class Category<T> : IEnumerable<Product<T>>
    {
        private List<Product<T>> products = new List<Product<T>>();

        public void Add(Product<T> product)
        {
            products.Add(product);
        }

        public void Add(string category, string name, T price, DateTime dateAdded)
        {
            products.Add(new Product<T>(category, name, price, dateAdded));
        }

        public IEnumerator<Product<T>> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Product<int>> GetByPriceRange(int min, int max)
        {
            foreach (var product in products)
            {
                if (product is Product<int> intProduct &&
                    intProduct.Price >= min &&
                    intProduct.Price <= max)
                {
                    yield return intProduct;
                }
            }
        }

        public IEnumerable<Product<double>> GetByPriceRange(double min, double max)
        {
            foreach (var product in products)
            {
                if (product is Product<double> doubleProduct &&
                    doubleProduct.Price >= min &&
                    doubleProduct.Price <= max)
                {
                    yield return doubleProduct;
                }
            }
        }

        public IEnumerable<Product<decimal>> GetByPriceRange(decimal min, decimal max)
        {
            foreach (var product in products)
            {
                if (product is Product<decimal> decimalProduct &&
                    decimalProduct.Price >= min &&
                    decimalProduct.Price <= max)
                {
                    yield return decimalProduct;
                }
            }
        }

        public IEnumerable<Product<T>> GetAddedInLastDays(int days)
        {
            DateTime fromDate = DateTime.Now.AddDays(-days);

            foreach (var product in products)
            {
                if (product.DateAdded >= fromDate)
                {
                    yield return product;
                }
            }
        }
    }
}