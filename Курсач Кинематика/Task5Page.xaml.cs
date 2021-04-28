using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Курсач_Кинематика
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Task5Page : Page
    {
        Task5 task5 = new Task5();
        public Task5Page()
        {
            this.InitializeComponent();
        }

        private void Solution(object sender, RoutedEventArgs e)
        {
            task5.solution();
            MessageDialog dialog;
            if (task5.res > 0)
                dialog = new MessageDialog($"v = {task5.v} м/с\na = {task5.res} м/c^2");
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
