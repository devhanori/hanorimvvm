using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace HanoriMvvm.UI.ViewModels
{
    internal class TitleBarViewModel : ObservableObject
    {
        #region Initialize
        public TitleBarViewModel() => Initialize();
        private void Initialize()
        {
            MainExitCommand = new RelayCommand(OnWindowExit);
            MainMiniCommand = new RelayCommand(OnWindowMini);
            MainMaxCommand = new RelayCommand(OnWindowMax);
        }
        #endregion

        #region Command
        public IRelayCommand? MainExitCommand { get; set; }
        public IRelayCommand? MainMiniCommand { get; set; }
        public IRelayCommand? MainMaxCommand { get; set; }
        #endregion

        #region  Mehod
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
