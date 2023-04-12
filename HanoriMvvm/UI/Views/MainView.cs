using HanoriMvvm.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HanoriMvvm.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            this.DataContext = App.Current.Services.GetService<MainViewModel>();
        }

        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }
    }
}
