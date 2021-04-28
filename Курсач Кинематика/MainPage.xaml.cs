using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Курсач_Кинематика
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string task1 = "Колонна войск во время похода движется со скоростью v1 км/ч, растянувшись по дороге на расстояние l км. Командир,\nнаходящийся в хвосте колонны, посылает велосипедиста с поручением головному отряду. Велосипедист отправляется и\nедет со скоростью v2 км/ч и, на ходу выполнив поручение, сразу же возвращается обратно с той же скоростью.\nЧерез сколько времени t после получения поручения он вернулся обратно?";
        string task2 = "Вагон шириной d м, движущийся со скоростью v м/с, был пробит пулей, летевшей перпендикулярно движению вагона.\nСмещение отверстий в стенках вагона относительно друг друга равно l м. Какова скорость движения пули?";
        string task3 = "Расстояние между двумя станциями s м поезд метро проходит со средней скоростью vср м/c. При этом на разгон он\nзатрачивает время t1 с, затем идет равномерно некоторое время t3 и на замедление до полной остановки тратит\nвремя t2 с. Построить график скорости движения поезда и определить наибольшую скорость поезда vмакс.";
        string task4 = "Первый вагон поезда прошел мимо наблюдателя, стоящего на платформе, за t1с, а второй — за t2 с. Длина вагона l м.\nНайти ускорение a поезда и его скорость v0 в начале наблюдения. Движение поезда считать равнопеременным.";
        string task5 = "Реактивный самолет летит со скоростью v0 м/c. С некоторого момента самолет движется с ускорением в течение t с и в\nпоследнюю секунду проходит путь s м. Определить ускорение a и конечную скорость v самолета";


        public MainPage()
        {
            this.InitializeComponent();
            
        }

        public object ContentFrame { get; private set; }

        private void StartTask1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Task1Page));
        }

        private void StartTask2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Task2Page));

        }

        private void StartTask3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Task3Page));
        }

        private void StartTask4(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Task4Page));
        }
        private void StartTask5(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Task5Page));
        }
    }
}
