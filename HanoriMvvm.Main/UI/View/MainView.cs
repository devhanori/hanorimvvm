using System.Windows;

namespace HanoriMvvm.UI.View
{
    public partial class MainView : Window
    {
        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }
    }
}
