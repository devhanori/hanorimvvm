﻿using HanoriMvvm.UI.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace HanoriMvvm.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        static MainView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainView), new FrameworkPropertyMetadata(typeof(MainView)));
        }
    }
}
