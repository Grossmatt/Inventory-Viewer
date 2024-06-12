using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Models
{
    public class Product
    {
        // Add an image property at some point
        public int ProdID { get; }
        public string Name { get; }

        public Product(int prodID, string name)
        {
            ProdID = prodID;
            Name = name;
        }

        internal bool Conflicts(Product product)
        {
            if (product.ProdID.Equals(ProdID))
            {
                return true;
            }

            return false;
        }
    }
}
