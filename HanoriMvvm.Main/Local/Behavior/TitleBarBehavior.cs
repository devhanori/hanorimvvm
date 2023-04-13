﻿using Microsoft.Xaml.Behaviors;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/// <summary>
/// Title Bar Click Event Handling
/// D:\00_WorkSpace\__MY_LHO_LOCAL\hanorimvvm\HanoriMvvm.Main\Local\Behavior\
/// 마우스 더블 클릭 이벤트 처리를 위해 ListView로 적용함
/// </summary>
namespace HanoriMvvm.Main.Local.Behavior
{
    public class TitleBarBehavior : Behavior<ListView>
    {
        protected override void OnAttached()
        {
            AssociatedObject.MouseLeftButtonDown += AssociatedObject_MouseLeftButtonDown;
            AssociatedObject.MouseDoubleClick += AssociatedObject_MouseDoubleClick;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.MouseLeftButtonDown -= AssociatedObject_MouseLeftButtonDown;
            AssociatedObject.MouseDoubleClick -= AssociatedObject_MouseDoubleClick;
        }
        private void AssociatedObject_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var _window = Window.GetWindow(sender as UIElement);
            if (_window.WindowState == WindowState.Normal)
            {
                _window.WindowState = WindowState.Maximized;
            }
            else
            {
                _window.WindowState = WindowState.Normal;
            }
        }

        private void AssociatedObject_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var _window = Window.GetWindow(sender as UIElement);
            if (_window.WindowState == WindowState.Normal)
            {
                _window.DragMove();
            }
        }
    }
}
