using Microsoft.Win32;
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
    /// Interaction logic for ImageWindow.xaml
    /// </summary>
    public partial class ImageWindow : Window
    {
        public static Image Image { get; set; }
        public ImageWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Image = new Image();
        }

        private void btnElipseOK_Click(object sender, RoutedEventArgs e)
        {
            if (Image.Width > 0 && Image.Height > 0 && Image.Source != null)
            {
                DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You must fill all fields!", "Error", MessageBoxButton.OK);
            }
        }

        private void btnElipseBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Slect a image";
            openFile.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (openFile.ShowDialog() == true)
            {
                Image.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void btnElispeCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
