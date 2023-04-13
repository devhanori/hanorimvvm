using HanoriMvvm.IoC;
using HanoriMvvm.UI.View;
using System.Windows;
using HanoriMvvm.Core.ViewModels.Main;

namespace HanoriMvvm
{
    public class App : Application
    {
        private static MainView? mainView;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            #region Main View Show
            mainView = new();
            mainView.WindowStyle = WindowStyle.None;
            mainView.AllowsTransparency = true;
            mainView.DataContext = IoCService.Instance.Services.GetService(typeof(MainViewModel));
            mainView.Show();
            #endregion
        }
    }
}
