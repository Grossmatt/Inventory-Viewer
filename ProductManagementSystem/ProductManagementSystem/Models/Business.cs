using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Business
    {
        private readonly Catalog _catalog;

        public string Name { get; }

        public Business(string name)
        {
            Name = name;

            _catalog = new Catalog();
        }


        public IEnumerable<Product> GetAllProducts()
        {
            return _catalog.GetAllProducts();
        }


        public IEnumerable<Product> GetSpecificProduct(int prod)
        {
            return _catalog.GetSpecificProduct(prod);
        }


        public void AddProduct(Product product)
        {
            _catalog.AddProduct(product);
        }
    }
}
