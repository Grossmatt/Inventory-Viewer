using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductManagementSystem.Models;
using ProductManagementSystem.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.ViewModels
{
    public partial class ProductsListViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;
        private readonly ObservableCollection<ProductViewModel> _products;

        public IEnumerable<ProductViewModel> Products => _products;


        public ProductsListViewModel(NavigationStore navigation)
        {
            _products = new ObservableCollection<ProductViewModel>();
            _navigationStore = navigation;
        }

        [RelayCommand]
        private void Disconnect()
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }
    }
}
