using HanoriMvvm.Core.ViewModels.Main;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HanoriMvvm.IoC
{
    public class IoCService
    {
        #region Singleton 
        private static readonly Lazy<IoCService> _instance = new Lazy<IoCService>(() => new IoCService());
        public static IoCService Instance { get { return _instance.Value; } }
        #endregion

        public IoCService() 
        {
            Services = ConfigureServices();
        }
        public IServiceProvider Services { get; }
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services

            // Viewmodels
            services.AddTransient<MainViewModel>();

            return services.BuildServiceProvider();
        }
    }
}
