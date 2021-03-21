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
using System.Windows.Shapes;

namespace PZ1
{
    /// <summary>
    /// Interaction logic for PolygonWindow.xaml
    /// </summary>
    public partial class PolygonWindow : Window
    {
        public static Polygon Polygon { get; set; }
        public PolygonWindow(List<Point> points)
        {
            InitializeComponent();
            this.DataContext = this;
            Polygon = new Polygon();
            Polygon.Points = new PointCollection();

            foreach(var item in points)
            {
                Polygon.Points.Add(item);
            }
        }

        private void btnElipseOK_Click(object sender, RoutedEventArgs e)
        {
            if (Polygon.StrokeThickness >= 0)
            {
                if (comboBoxPolygonFill.SelectedIndex == 0)
                {
                    Polygon.Fill = Brushes.Red;
                }
                else if (comboBoxPolygonFill.SelectedIndex == 1)
                {
                    Polygon.Fill = Brushes.Blue;
                }
                else if (comboBoxPolygonFill.SelectedIndex == 2)
                {
                    Polygon.Fill = Brushes.Brown;
                }
                else if (comboBoxPolygonFill.SelectedIndex == 3)
                {
                    Polygon.Fill = Brushes.Green;
                }
                else if (comboBoxPolygonFill.SelectedIndex == 4)
                {
                    Polygon.Fill = Brushes.Orange;
                }
                else if (comboBoxPolygonFill.SelectedIndex == 5)
                {
                    Polygon.Fill = Brushes.Yellow;
                }



                if (comboBoxPolygonBorder.SelectedIndex == 0)
                {
                    Polygon.Stroke = Brushes.Red;
                }
                else if (comboBoxPolygonBorder.SelectedIndex == 1)
                {
                    Polygon.Stroke = Brushes.Blue;
                }
                else if (comboBoxPolygonBorder.SelectedIndex == 2)
                {
                    Polygon.Stroke = Brushes.Brown;
                }
                else if (comboBoxPolygonBorder.SelectedIndex == 3)
                {
                    Polygon.Stroke = Brushes.Green;
                }
                else if (comboBoxPolygonBorder.SelectedIndex == 4)
                {
                    Polygon.Stroke = Brushes.Orange;
                }
                else if (comboBoxPolygonBorder.SelectedIndex == 5)
                {
                    Polygon.Stroke = Brushes.Yellow;
                }

                DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields!", "Error", MessageBoxButton.OK);
            }

        }

        private void btnElispeCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
