using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HanoriMvvm.UI.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        #region Initialize
        public MainViewModel() => Initialize();
        private void Initialize()
        {
            //SearchBar = App.Current.Services.GetService<WinControl>();
            //CurrentView = App.Current.Services.GetService<WinControl>();

            // Window Control
            MainExitCommand = new RelayCommand(OnWindowExit);
            MainMiniCommand = new RelayCommand(OnWindowMini);
            MainMaxCommand = new RelayCommand(OnWindowMax);
        }
        #endregion

        #region Member
        #region Window Control Command
        public IRelayCommand? MainExitCommand { get; set; }
        public IRelayCommand? MainMiniCommand { get; set; }
        public IRelayCommand? MainMaxCommand { get; set; }
        #endregion

        // Menu 제어 로직 필요

        private object? _searchBar;
        public object? SearchBar
        {
            get { return _searchBar; }
            set { SetProperty(ref _searchBar, value); }
        }

        private object? _currentView;
        public object? CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }
        #endregion

        #region Window Control Method
        private void OnWindowExit()
        {
            if (MessageBox.Show("Do you want shutdown ?", "Warning", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                App.Current.MainWindow.Close();
            }
        }

        private void OnWindowMini()
        {
            App.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void OnWindowMax()
        {
            if (App.Current.MainWindow.WindowState == WindowState.Normal)
            {
                App.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                App.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }
        #endregion
    }
}
