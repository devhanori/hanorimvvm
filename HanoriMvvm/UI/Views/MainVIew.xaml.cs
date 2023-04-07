using HanoriMvvm.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HanoriMvvm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService<MainViewModel>();
        }
    }
}
