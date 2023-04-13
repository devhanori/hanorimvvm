using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HanoriMvvm.Core.LocalWorks.Main.Work;

namespace HanoriMvvm.Core.ViewModels.Main
{
    public partial class MainViewModel : ObservableObject
    {
        #region Initialize
        public MainViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            #region Window Ctrl Init
            WinCtrl = new();
            MainExitCommand = new RelayCommand<object?>(WinCtrl.ClosingWindow);
            MainMiniCommand = new RelayCommand<object?>(WinCtrl.MinizingWindow);
            MainMaxCommand = new RelayCommand<object?>(WinCtrl.MaximizingWindow);
            #endregion Window Ctrl Init
        }
        #endregion

        #region Member
        #region Window Control
        public WindowCtrl? WinCtrl { get; set; }
        public IRelayCommand? MainExitCommand { get; set; }
        public IRelayCommand? MainMiniCommand { get; set; }
        public IRelayCommand? MainMaxCommand { get; set; }
        #endregion Window Control

        #region Menu Control

        #endregion

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
    }
}
