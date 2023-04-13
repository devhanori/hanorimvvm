using System.Windows;
using System.Windows.Controls;

namespace HanoriMvvm.Main.UI.Units
{
    public class MainMenu : UserControl
    {
        static MainMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainMenu), new FrameworkPropertyMetadata(typeof(MainMenu)));
        }
    }
}
