using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using HanoriMvvm.Main.Local.ViewModel;
using HanoriMvvm.UI.Views;

namespace HanoriMvvm
{
    public partial class App : Application
    {
        public App()
        {
            //this.InitializeComponent();

            Services = ConfigureServices();
        }

        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }
        public MainView? mainView;
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            #region Services
            // Services

            #endregion

            #region ViewModels
            // Viewmodels
            services.AddTransient<MainViewModel>();
            #endregion

            return services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            
            #region Main View Show
            mainView = new();
            mainView.WindowStyle= WindowStyle.None;
            mainView.AllowsTransparency = true;
            mainView.DataContext = App.Current.Services.GetService<MainViewModel>();
            mainView.Show();
            #endregion
        }
    }
}
