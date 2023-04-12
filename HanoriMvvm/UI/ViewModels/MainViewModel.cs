using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace HanoriMvvm.UI.ViewModels
{
    internal partial class MainViewModel : ObservableObject
    {
        #region Initialize
        public MainViewModel() => Initialize();
        private void Initialize()
        {
            SystemBar = App.Current.Services.GetService<TitleBarViewModel>();
            SearchBar = App.Current.Services.GetService<TitleBarViewModel>();
            CurrentView = App.Current.Services.GetService<TitleBarViewModel>();
        }
        #endregion

        #region Member
        private object? _systemBar;
        public object? SystemBar
        {
            get { return _systemBar; }
            set { SetProperty(ref _systemBar, value); }
        }

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
