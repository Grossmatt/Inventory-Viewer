using CommunityToolkit.Mvvm.ComponentModel;
using ProductManagementSystem.Models;
using ProductManagementSystem.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        private readonly NavigationStore _navigationStore;

        public ObservableObject CurrentViewModel => _navigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigation)
        {
            _navigationStore = navigation;
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
