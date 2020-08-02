using System;
using System.Windows;
using System.Windows.Input;

namespace CursorCoordinates
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MouseMove += MainWindow_MouseMove;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            var point = e.GetPosition(this) - new Point(Width / 2, Height / 2);
            var x = point.X;
            var y = point.Y;
            this.Title = x.ToString() + ":" + y.ToString();

            var point2 = new Point(0, 0);
            var x2 = point2.X;
            var y2 = point2.Y;
            var k = (y - y2) / (x2 - x);
            this.Title += "  k:" + k;

            rrt.Angle = 90 - Math.Atan(k) * 180 / Math.PI;
        }
    }
}