using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    public class ProductManager : IEnumerable<Product>
    {
        private List<Product> _products;

        public ProductManager()
            : this(new List<Product>())
        {

        }

        public ProductManager(List<Product> initialProducts) 
        { 
            _products = new List<Product>(initialProducts);
        }

        public void Add(Product product) 
        { 
            if (product != null)
            {
                _products.Add(product);
            }
            
        }

        public void Remove(Product product) 
        {
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public Product FindById(int id)
        { 
            foreach (Product product in _products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }

            return null;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _products.GetEnumerator();
        }
    }
}
