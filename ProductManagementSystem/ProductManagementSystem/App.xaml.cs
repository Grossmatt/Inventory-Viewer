using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProductManagementSystem.Models;
using ProductManagementSystem.Stores;
using ProductManagementSystem.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ProductManagementSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        private readonly Business _bussiness;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _bussiness = new Business("Temp");
            _navigationStore = new NavigationStore();
            /*AppHost = Host.CreateDefaultBuilder().ConfigureServices((hostContext, services) =>
            {
                services.AddSingleton<MainWindow>();
            }).Build();*/
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
            /*await AppHost!.StartAsync();

            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();*/

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            //Business business = new Business("Temp");


            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }

}
