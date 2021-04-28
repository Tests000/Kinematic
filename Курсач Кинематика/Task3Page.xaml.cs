using System;
using Windows.UI.Popups;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Курсач_Кинематика
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class Task3Page : Page
    {
        Task3 task3 = new Task3();

        public Task3Page()
        {
            this.InitializeComponent();
        }

        private void Solution(object sender, RoutedEventArgs e)
        {
            task3.solution();
            if (task3.res > 0)
            {
                while(this.grid.Children.Count>4)
                {
                    this.grid.Children.RemoveAt(4);
                }
                drawaxes();
                drawx();
                drawy();
                drawgraph();
                drawdata();
                this.Content = grid;
            }
            else
            {
                MessageDialog dialog = new MessageDialog($"Введены некорректные данные");
                dialog.ShowAsync().AsTask();
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void drawdata()
        {
            var t1 = new TextBlock();
            t1.FontSize = 20;
            Thickness t1inf;
            t1inf.Left = task3.t1 * 200 / (task3.t1 + task3.t2 + task3.t3) + 100;
            t1inf.Top = 310;
            t1.Margin = t1inf;
            t1.Text = $"{Math.Round(task3.t1, 2)}c";
            Grid.SetColumn(t1, 0);
            Grid.SetRow(t1, 6);
            grid.Children.Add(t1);

            var t2 = new TextBlock();
            t2.FontSize = 20;
            Thickness t2inf;
            t2inf.Left = (task3.t1 + task3.t3) * 200 / (task3.t1 + task3.t2 + task3.t3) + 100;
            t2inf.Top = 310;
            t2.Margin = t2inf;
            t2.Text = $"{Math.Round(task3.t1 + task3.t3, 2)}c";
            Grid.SetColumn(t2, 0);
            Grid.SetRow(t2, 6);
            grid.Children.Add(t2);

            var v = new TextBlock();
            v.FontSize = 20;
            Thickness vinf;
            vinf.Left = 20;
            vinf.Top = 180;
            v.Margin = vinf;
            v.Text = $"{Math.Round(task3.res, 2)}м/c";
            Grid.SetColumn(v, 0);
            Grid.SetRow(v, 6);
            grid.Children.Add(v);

            var v0 = new TextBlock();
            v0.FontSize = 30;
            v0.Text = $"V0 = {Math.Round(task3.res, 2)}м/c";
            Grid.SetColumn(v0, 0);
            Grid.SetRow(v0, 5);
            grid.Children.Add(v0);
        }

        private void drawx()
        {
            var x = new TextBlock();
            x.FontSize = 30;
            Thickness xinf;
            xinf.Left = 400;
            xinf.Top = 290;
            x.Margin = xinf;
            x.Text = "t";
            Grid.SetColumn(x, 0);
            Grid.SetRow(x, 6);
            grid.Children.Add(x);
        }

        private void drawy()
        {
            var y = new TextBlock();
            y.FontSize = 30;
            Thickness yinf;
            yinf.Left = 130;
            yinf.Top = 0;
            y.Margin = yinf;
            y.Text = "v";
            Grid.SetColumn(y, 0);
            Grid.SetRow(y, 6);
            grid.Children.Add(y);
        }

        private void drawaxes()
        {

            var polyline = new Polyline();
            var points = new PointCollection();
            var pointsar1 = new PointCollection();
            var pointsar2 = new PointCollection();
            var arrow1 = new Polyline();
            var arrow2 = new Polyline();
            pointsar1.Add(new Windows.Foundation.Point(110, 40));
            pointsar1.Add(new Windows.Foundation.Point(120, 30));
            pointsar1.Add(new Windows.Foundation.Point(130, 40));
            points.Add(new Windows.Foundation.Point(120, 30));
            points.Add(new Windows.Foundation.Point(120, 300));
            points.Add(new Windows.Foundation.Point(400, 300));
            pointsar2.Add(new Windows.Foundation.Point(390, 290));
            pointsar2.Add(new Windows.Foundation.Point(400, 300));
            pointsar2.Add(new Windows.Foundation.Point(390, 310));
            polyline.Stroke = new SolidColorBrush(Windows.UI.Colors.White);
            polyline.StrokeThickness = 4;
            polyline.Points = points;
            Grid.SetColumn(polyline, 0);
            Grid.SetRow(polyline, 6);
            grid.Children.Add(polyline);
            arrow1.Stroke = new SolidColorBrush(Windows.UI.Colors.White);
            arrow1.StrokeThickness = 4;
            arrow1.Points = pointsar1;
            Grid.SetColumn(arrow1, 0);
            Grid.SetRow(arrow1, 6);
            grid.Children.Add(arrow1);
            arrow2.Stroke = new SolidColorBrush(Windows.UI.Colors.White);
            arrow2.StrokeThickness = 4;
            arrow2.Points = pointsar2;
            Grid.SetColumn(arrow2, 0);
            Grid.SetRow(arrow2, 6);
            grid.Children.Add(arrow2);
        }

        private void drawgraph()
        {
            var grp = new PointCollection();
            var graph = new Polyline();
            grp.Add(new Windows.Foundation.Point(120, 300));
            grp.Add(new Windows.Foundation.Point(task3.t1 * 200 / (task3.t1 + task3.t2 + task3.t3) + 120, 200));
            grp.Add(new Windows.Foundation.Point(((task3.t1 + task3.t3) * 200 + 20) / (task3.t1 + task3.t2 + task3.t3) + 100, 200));
            grp.Add(new Windows.Foundation.Point(320, 300));
            graph.Stroke = new SolidColorBrush(Windows.UI.Colors.LightGray);
            graph.StrokeThickness = 3;
            graph.Points = grp;
            Grid.SetColumn(graph, 0);
            Grid.SetRow(graph, 6);
            grid.Children.Add(graph);
        }
    }
}
