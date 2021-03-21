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
    /// Interaction logic for RectangleWindow.xaml
    /// </summary>
    public partial class RectangleWindow : Window
    {
        public static Rectangle Rectangle { get; set; }
        public RectangleWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Rectangle = new Rectangle();
        }

        private void btnElispeCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        private void btnElipseOK_Click(object sender, RoutedEventArgs e)
        {
            if (Rectangle.Width > 0 && Rectangle.Height > 0 && Rectangle.StrokeThickness >= 0)
            {
                if (comboBoxRectangleFill.SelectedIndex == 0)
                {
                    Rectangle.Fill = Brushes.Red;
                }
                else if (comboBoxRectangleFill.SelectedIndex == 1)
                {
                    Rectangle.Fill = Brushes.Blue;
                }
                else if (comboBoxRectangleFill.SelectedIndex == 2)
                {
                    Rectangle.Fill = Brushes.Brown;
                }
                else if (comboBoxRectangleFill.SelectedIndex == 3)
                {
                    Rectangle.Fill = Brushes.Green;
                }
                else if (comboBoxRectangleFill.SelectedIndex == 4)
                {
                    Rectangle.Fill = Brushes.Orange;
                }
                else if (comboBoxRectangleFill.SelectedIndex == 5)
                {
                    Rectangle.Fill = Brushes.Yellow;
                }



                if (comboBoxRectangleBorder.SelectedIndex == 0)
                {
                    Rectangle.Stroke = Brushes.Red;
                }
                else if (comboBoxRectangleBorder.SelectedIndex == 1)
                {
                    Rectangle.Stroke = Brushes.Blue;
                }
                else if (comboBoxRectangleBorder.SelectedIndex == 2)
                {
                    Rectangle.Stroke = Brushes.Brown;
                }
                else if (comboBoxRectangleBorder.SelectedIndex == 3)
                {
                    Rectangle.Stroke = Brushes.Green;
                }
                else if (comboBoxRectangleBorder.SelectedIndex == 4)
                {
                    Rectangle.Stroke = Brushes.Orange;
                }
                else if (comboBoxRectangleBorder.SelectedIndex == 5)
                {
                    Rectangle.Stroke = Brushes.Yellow;
                }
                DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields!", "Error", MessageBoxButton.OK);
            }
        }
    }
}
