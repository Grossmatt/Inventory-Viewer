using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Google.Protobuf.WellKnownTypes;
using ProductManagementSystem.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductManagementSystem.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;

        [ObservableProperty]
        private string? serverlocation;

        [ObservableProperty]
        private string? dbname;

        [ObservableProperty]
        private string? username;

        [RelayCommand]
        private void Connect()
        { 
            // Try to connect here
            if (true)
            {
                _navigationStore.CurrentViewModel = new ProductsListViewModel(_navigationStore);
            }
        }

        public LoginViewModel(NavigationStore navigation)
        {
            _navigationStore = navigation;
        }
    }
}
