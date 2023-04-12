using HanoriMvvm.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HanoriMvvm
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            
            Services = ConfigureServices();
        }

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services


            // Viewmodels
            services.AddTransient<MainViewModel>();
            services.AddTransient<TitleBarViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
