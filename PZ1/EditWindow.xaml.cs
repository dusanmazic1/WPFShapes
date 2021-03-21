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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public static Shape Shape { get; set; }
        public EditWindow(Shape shape)
        {
            InitializeComponent();
            this.DataContext = this;
            Shape = shape;
        }

        private void btnElipseOK_Click(object sender, RoutedEventArgs e)
        {
            if (Shape.StrokeThickness >= 0)
            {
                if (comboBoxEditFill.SelectedIndex == 0)
                {
                    Shape.Fill = Brushes.Red;
                }
                else if (comboBoxEditFill.SelectedIndex == 1)
                {
                    Shape.Fill = Brushes.Blue;
                }
                else if (comboBoxEditFill.SelectedIndex == 2)
                {
                    Shape.Fill = Brushes.Brown;
                }
                else if (comboBoxEditFill.SelectedIndex == 3)
                {
                    Shape.Fill = Brushes.Green;
                }
                else if (comboBoxEditFill.SelectedIndex == 4)
                {
                    Shape.Fill = Brushes.Orange;
                }
                else if (comboBoxEditFill.SelectedIndex == 5)
                {
                    Shape.Fill = Brushes.Yellow;
                }



                if (comboBoxEditBorder.SelectedIndex == 0)
                {
                    Shape.Stroke = Brushes.Red;
                }
                else if (comboBoxEditBorder.SelectedIndex == 1)
                {
                    Shape.Stroke = Brushes.Blue;
                }
                else if (comboBoxEditBorder.SelectedIndex == 2)
                {
                    Shape.Stroke = Brushes.Brown;
                }
                else if (comboBoxEditBorder.SelectedIndex == 3)
                {
                    Shape.Stroke = Brushes.Green;
                }
                else if (comboBoxEditBorder.SelectedIndex == 4)
                {
                    Shape.Stroke = Brushes.Orange;
                }
                else if (comboBoxEditBorder.SelectedIndex == 5)
                {
                    Shape.Stroke = Brushes.Yellow;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields!", "Error", MessageBoxButton.OK);
            }
        }

        private void btnElispeCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
