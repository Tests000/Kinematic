using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Курсач_Кинематика
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Task1Page : Page
    {
        Task1 task1 = new Task1();
        public Task1Page()
        {
            this.InitializeComponent();
        }

        private void Solution(object sender, RoutedEventArgs e)
        {
            task1.solution();
            MessageDialog dialog;
            if (task1.res >0)
                dialog = new MessageDialog($"t = {task1.res} с");
            else
                dialog = new MessageDialog($"Введены некорректные данные");
            dialog.ShowAsync().AsTask();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
