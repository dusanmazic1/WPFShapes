using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PZ1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Point> rightClicks = new List<Point>();
        //List<UIElement> removedElements = new List<UIElement>();

        bool elipseClicked = false;
        bool rectangleClicked = false;
        bool polygonClicked = false;
        bool imageClicked = false;
        //bool clearClicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            elipseClicked = true;
            rectangleClicked = false;
            polygonClicked = false;
            imageClicked = false;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            elipseClicked = false;
            rectangleClicked = true;
            polygonClicked = false;
            imageClicked = false;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            elipseClicked = false;
            rectangleClicked = false;
            polygonClicked = true;
            imageClicked = false;
            rightClicks.Clear();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            elipseClicked = false;
            rectangleClicked = false;
            polygonClicked = false;
            imageClicked = true;
        }


        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (polygonClicked == true)
            {
                PolygonWindow pw = new PolygonWindow(rightClicks);
                pw.ShowDialog();

                if (pw.DialogResult == true)
                {
                    canvas.Children.Add(PolygonWindow.Polygon);
                }
                polygonClicked = false;
                rightClicks.Clear();
            }

            if(e.OriginalSource is Shape)
            {
                Shape shape = (Shape)e.OriginalSource;
                EditWindow ew = new EditWindow(shape);
                ew.Show();
            }
            else if(e.OriginalSource is Image)
            {
                Image image = (Image)e.OriginalSource;
                EditImageWindow eiw = new EditImageWindow(image);
                eiw.Show();
            }
        }

        private void canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point point = Mouse.GetPosition(canvas);
            if (elipseClicked == true)
            {
                ElipseWindow ew = new ElipseWindow();
                ew.ShowDialog();

                if (ew.DialogResult == true)
                {
                    Canvas.SetLeft(ElipseWindow.Ellipse, point.X);
                    Canvas.SetTop(ElipseWindow.Ellipse, point.Y);
                    canvas.Children.Add(ElipseWindow.Ellipse);
                }
                elipseClicked = false;
            }
            else if (rectangleClicked == true)
            {
                RectangleWindow rw = new RectangleWindow();
                rw.ShowDialog();

                if (rw.DialogResult == true)
                {
                    Canvas.SetLeft(RectangleWindow.Rectangle, point.X);
                    Canvas.SetTop(RectangleWindow.Rectangle, point.Y);
                    canvas.Children.Add(RectangleWindow.Rectangle);
                }
                rectangleClicked = false;
            }
            else if(polygonClicked == true)
            {
                rightClicks.Add(point);
            }
            else if(imageClicked == true)
            {
                ImageWindow iw = new ImageWindow();
                iw.ShowDialog();

                if(iw.DialogResult == true)
                {
                    Canvas.SetLeft(ImageWindow.Image, point.X);
                    Canvas.SetTop(ImageWindow.Image, point.Y);
                    canvas.Children.Add(ImageWindow.Image);
                }
                imageClicked = false;
            }
        }
    }
}
