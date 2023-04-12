using HanoriMvvm.UI.ViewModels;
using HanoriMvvm.UI.Views;
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
        public MainView mainView;
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services


            // Viewmodels
            services.AddTransient<MainViewModel>();

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            mainView = new MainView();
            mainView.WindowStyle= WindowStyle.None;
            mainView.AllowsTransparency = true;
            mainView.Show();
        }
    }
}
