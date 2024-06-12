using CommunityToolkit.Mvvm.ComponentModel;
using ProductManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.ViewModels
{
    public partial class ProductViewModel : ObservableObject
    {
        private readonly Product _product;

        public string? ProdID => _product.ProdID.ToString();

        public string Name => _product.Name;

        public ProductViewModel(Product product)
        {
            _product = product;
        }
    }
}
