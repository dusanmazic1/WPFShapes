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
    /// Interaction logic for ElipseWindow.xaml
    /// </summary>
    public partial class ElipseWindow : Window
    {
        public static Ellipse Ellipse { get; set; }
        public ElipseWindow()
        {
            InitializeComponent();
            Ellipse = new Ellipse();
            this.NamedColors = this.GetColors();
            this.DataContext = this;  
        }

        private void btnElispeCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }

        public IEnumerable<KeyValuePair<String, Color>> NamedColors
        {
            get;
            private set;
        }

        private IEnumerable<KeyValuePair<String, Color>> GetColors()
        {
            return typeof(Colors)
                .GetProperties()
                .Where(prop =>
                    typeof(Color).IsAssignableFrom(prop.PropertyType))
                .Select(prop =>
                    new KeyValuePair<String, Color>(prop.Name, (Color)prop.GetValue(null)));
        }

        private void btnElipseOK_Click(object sender, RoutedEventArgs e)
        {
            if(Ellipse.Width > 0 && Ellipse.Height > 0 && Ellipse.StrokeThickness >= 0)
            {
                if(comboBoxElipseFill.SelectedIndex == 0)
                {
                    Ellipse.Fill = Brushes.Red;
                }
                else if (comboBoxElipseFill.SelectedIndex == 1)
                {
                    Ellipse.Fill = Brushes.Blue;
                }
                else if (comboBoxElipseFill.SelectedIndex == 2)
                {
                    Ellipse.Fill = Brushes.Brown;
                }
                else if (comboBoxElipseFill.SelectedIndex == 3)
                {
                    Ellipse.Fill = Brushes.Green;
                }
                else if (comboBoxElipseFill.SelectedIndex == 4)
                {
                    Ellipse.Fill = Brushes.Orange;
                }
                else if (comboBoxElipseFill.SelectedIndex == 5)
                {
                    Ellipse.Fill = Brushes.Yellow;
                }



                if (comboBoxElipseBorder.SelectedIndex == 0)
                {
                    Ellipse.Stroke = Brushes.Red;
                }
                else if (comboBoxElipseBorder.SelectedIndex == 1)
                {
                    Ellipse.Stroke = Brushes.Blue;
                }
                else if (comboBoxElipseBorder.SelectedIndex == 2)
                {
                    Ellipse.Stroke = Brushes.Brown;
                }
                else if (comboBoxElipseBorder.SelectedIndex == 3)
                {
                    Ellipse.Stroke = Brushes.Green;
                }
                else if (comboBoxElipseBorder.SelectedIndex == 4)
                {
                    Ellipse.Stroke = Brushes.Orange;
                }
                else if (comboBoxElipseBorder.SelectedIndex == 5)
                {
                    Ellipse.Stroke = Brushes.Yellow;
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
