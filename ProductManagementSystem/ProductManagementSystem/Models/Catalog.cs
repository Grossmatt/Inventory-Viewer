using ProductManagementSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Catalog
    {
        private readonly List<Product> _products;

        public Catalog()
        {
            _products = new List<Product>();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public IEnumerable<Product> GetSpecificProduct(int productID)
        {
            return _products.Where(r => r.ProdID.Equals(productID));
        }

        public void AddProduct(Product product)
        {
            foreach (Product prod in _products)
            {
                if (prod.Conflicts(product))
                {
                    throw new ProductConflictException(prod, product);
                }
            }

            _products.Add(product);
        }
    }
}
