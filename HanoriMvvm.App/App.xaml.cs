using HanoriMvvm.Core.Services;
using HanoriMvvm.Core.ViewModels.MainWindow;
using HanoriMvvm.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace HanoriMvvm.App
{
    public partial class HanoriApp : Application
    {
        public HanoriApp()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }
        public new static HanoriApp Current => (HanoriApp)Application.Current;
        public IServiceProvider Services { get; }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services
            services.AddSingleton<ITestService, TestService01>();
            services.AddSingleton<ITestService, TestService02>();

            // Viewmodels
            services.AddTransient<MainWindowViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
