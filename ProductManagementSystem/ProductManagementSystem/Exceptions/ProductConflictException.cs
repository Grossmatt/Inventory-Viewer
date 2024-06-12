using ProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.Exceptions
{
    public class ProductConflictException : Exception
    {
        public Product ExistingProduct { get; }
        public Product IncomingProduct { get; }

        public ProductConflictException(Product existingProduct, Product incomingProduct)
        {
            ExistingProduct = existingProduct;
            IncomingProduct = incomingProduct;
        }

        public ProductConflictException(string? message, Product existingProduct, Product incomingProduct) : base(message)
        {
            ExistingProduct = existingProduct;
            IncomingProduct = incomingProduct;
        }

        public ProductConflictException(string? message, Exception? innerException, Product existingProduct, Product incomingProduct) : base(message, innerException)
        {
            ExistingProduct = existingProduct;
            IncomingProduct = incomingProduct;
        }

        protected ProductConflictException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
